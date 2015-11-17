using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PracticeBootstrap.Startup))]
namespace PracticeBootstrap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
