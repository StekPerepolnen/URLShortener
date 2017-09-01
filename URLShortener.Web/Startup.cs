using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(URLShortener.Web.Startup))]
namespace URLShortener.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
