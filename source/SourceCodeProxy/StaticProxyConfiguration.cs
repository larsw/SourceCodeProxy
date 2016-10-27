namespace SourceCodeProxy
{
    public class StaticProxyConfiguration : IProxyConfiguration
    {
        public string StashBaseUrl { get; set; } = "NOT_SET";
        public string StashUser { get; set; } = "NOT_SET";
        public string StashPassword { get; set; } = "NOT_SET";
    }
}