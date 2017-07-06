using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoApplication4.Startup))]
namespace DemoApplication4
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
