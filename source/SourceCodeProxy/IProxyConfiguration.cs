namespace SourceCodeProxy
{
    public interface IProxyConfiguration
    {
        string StashBaseUrl { get; }
        string StashUser { get; }
        string StashPassword { get; }
    }
}