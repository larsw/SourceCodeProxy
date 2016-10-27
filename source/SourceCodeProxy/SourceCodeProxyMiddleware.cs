namespace SourceCodeProxy
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    using Microsoft.Owin;

    class SourceCodeProxyMiddleware : OwinMiddleware
    {
        private readonly Regex _regex = new Regex(@"/(?<projectKey>[a-zA-Z0-9\-_]+)/(?<repo>[a-zA-Z0-9\-_]+)/(?<untilHash>[a-z0-9]+)/(?<filePath>.*)");
        private readonly SourceCodeProxyOptions _options;

        public SourceCodeProxyMiddleware(OwinMiddleware next, SourceCodeProxyOptions options) : base(next)
        {
            _options = options;
        }

        public override async Task Invoke(IOwinContext context)
        {

            if (context.Request.Method != HttpMethod.Get.Method)
            {
                context.Response.StatusCode = (int)HttpStatusCode.MethodNotAllowed;
                context.Response.ReasonPhrase = "The SourceCodeProxy service does only allow the GET HTTP verb.";
                return;
            }

            // Show welcome/help screen.
            if (_options.ProcessWelcomeRequest != null && (!context.Request.Path.HasValue || context.Request.Path.Value == "/"))
            {
                await _options.ProcessWelcomeRequest(context);
                return;
            }

            if (_options.ProcessLicenseRequest != null && context.Request.Path.Value == "/LICENSE")
            {
                await _options.ProcessLicenseRequest(context);
                return;
            }

            var match = _regex.Match(context.Request.Path.Value);
            if (!match.Success)
            {
                context.Response.StatusCode = (int) HttpStatusCode.BadRequest;
                context.Response.ReasonPhrase =
                    $"The proxy service could not parse the URL path \"{context.Request.Path.Value}\"";
                return;
            }

            var projectKey = match.Groups["projectKey"].Value;
            var repo = match.Groups["repo"].Value;
            var untilHash = match.Groups["untilHash"].Value;
            var filePath = match.Groups["filePath"].Value;
            var proxyConfiguration = _options.ProxyConfiguration;

            var fileUrl = $"{proxyConfiguration.StashBaseUrl}/projects/{projectKey}/repos/{repo}/browse/{filePath}?until={untilHash}&raw";

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = ConstructAuthorizationHeader(proxyConfiguration.StashUser, proxyConfiguration.StashPassword);
            var response = await httpClient.GetAsync(fileUrl);

            context.Response.StatusCode = (int)response.StatusCode;
            context.Response.ContentType = response.Content.Headers.ContentType.ToString();

            var responseStream = await response.Content.ReadAsStreamAsync();

            await responseStream.CopyToAsync(context.Response.Body);

            httpClient.Dispose();
        }

        private static AuthenticationHeaderValue ConstructAuthorizationHeader(string stashUser, string stashPassword)
        {
            return new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes($"{stashUser}:{stashPassword}")));
        }
    }
}