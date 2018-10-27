using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JWebSite.Startup))]
namespace JWebSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
