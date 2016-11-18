using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCProjectWithTests.Startup))]
namespace MVCProjectWithTests
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
