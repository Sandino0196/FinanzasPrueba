using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FrontFinanzas.Startup))]
namespace FrontFinanzas
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
