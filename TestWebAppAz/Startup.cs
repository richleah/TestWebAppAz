using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestWebAppAz.Startup))]
namespace TestWebAppAz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
