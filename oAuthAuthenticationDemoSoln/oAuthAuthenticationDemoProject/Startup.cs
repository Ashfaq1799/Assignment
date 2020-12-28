using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(oAuthAuthenticationDemoProject.Startup))]
namespace oAuthAuthenticationDemoProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
