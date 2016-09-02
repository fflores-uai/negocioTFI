using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Presentation.WebSite.Startup))]
namespace Presentation.WebSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
