using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MikeWebsite.Startup))]
namespace MikeWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
