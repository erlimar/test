using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestNugetRestorePackages.Startup))]
namespace TestNugetRestorePackages
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
