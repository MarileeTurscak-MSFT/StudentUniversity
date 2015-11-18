using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MySpace.Startup))]
namespace MySpace
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
