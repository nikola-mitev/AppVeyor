using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppVeyorBuildDeploy.Startup))]
namespace AppVeyorBuildDeploy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
