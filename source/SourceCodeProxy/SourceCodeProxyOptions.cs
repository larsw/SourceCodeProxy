namespace SourceCodeProxy
{
    using System;
    using System.IO;
    using System.Reflection;
    using System.Threading.Tasks;
    using HeyRed.MarkdownSharp;
    using Microsoft.Owin;

    public class SourceCodeProxyOptions
    {
        private const string CssResourceName = "SourceCodeProxy.milligram.min.css";
        private const string ReadmeResourceName = "SourceCodeProxy.README.md";
        private const string LicenseResourceName = "SourceCodeProxy.LICENSE";

        public Func<IOwinContext, Task> ProcessWelcomeRequest = WelcomeHandler;
        public Func<IOwinContext, Task> ProcessLicenseRequest = LicenseHandler; 
        public IProxyConfiguration ProxyConfiguration = new StaticProxyConfiguration();

        private static async Task LicenseHandler(IOwinContext context)
        {
            context.Response.ContentType = "text/plain";
            var license = GetResourceFileContent(LicenseResourceName);
            await context.Response.WriteAsync(license);
        }

        private static async Task WelcomeHandler(IOwinContext context)
        {
            var markdown = GetResourceFileContent(ReadmeResourceName);
            var bodyContent = GeneratePageFromMarkdown(markdown);
            context.Response.ContentType = "text/html";
            await context.Response.WriteAsync(bodyContent);
        }

        public static string GeneratePageFromMarkdown(string markdown)
        {
            var markdownProcessor = new Markdown();
            var content = markdownProcessor.Transform(markdown);
            return GeneratePage(content);
        }

        private static string GeneratePage(string content)
        {
            var css = GetResourceFileContent(CssResourceName);
            var welcomeHtmlStart =
                $"<html><head><title>SourceCodeProxy: Welcome</title><style type=\"text/css\">{css}</style></head><body><div class=\"container\"><div class=\"row\"></div><div class=\"column column-50 column-offset-25\">";
            const string welcomeHtmlEnd = "</div></div></div></body></html>";
            var bodyContent = string.Concat(welcomeHtmlStart, content, welcomeHtmlEnd);
            return bodyContent;
        }

        private static string GetResourceFileContent(string resourceName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                {
                    return $"<h1>Error: \"{resourceName}\" not found.</h1>";
                }
                var reader = new StreamReader(stream);
                return reader.ReadToEnd();
            }
        }
    }
}