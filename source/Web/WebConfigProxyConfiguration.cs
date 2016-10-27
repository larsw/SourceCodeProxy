namespace SourceCodeProxy.Web
{
    using System.Web.Configuration;

    public class WebConfigProxyConfiguration : IProxyConfiguration
    {
        public string StashBaseUrl { get; } = WebConfigurationManager.AppSettings["sourceCodeProxy:stashBaseUrl"];
        public string StashUser { get; } = WebConfigurationManager.AppSettings["sourceCodeProxy:stashUser"];
        public string StashPassword { get; } = WebConfigurationManager.AppSettings["sourceCodeProxy:stashPassword"];
    }
}