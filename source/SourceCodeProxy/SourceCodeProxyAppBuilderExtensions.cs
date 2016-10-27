namespace SourceCodeProxy
{
    using Owin;

    public static class SourceCodeProxyAppBuilderExtensions
    {
        public static IAppBuilder UseSourceCodeProxy(this IAppBuilder app, SourceCodeProxyOptions options = null)
        {
            options = options ?? new SourceCodeProxyOptions();
            app.Use<SourceCodeProxyMiddleware>(options);
            return app;
        }
    }
}