using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Smsproz.Startup))]
namespace Smsproz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
