using Microsoft.Owin;
using SourceCodeProxy.Web;

[assembly: OwinStartup(typeof(Startup))]

namespace SourceCodeProxy.Web
{
    using Owin;

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseSourceCodeProxy(new SourceCodeProxyOptions
            {
                ProxyConfiguration = new WebConfigProxyConfiguration()
            });
        }
    }
}
