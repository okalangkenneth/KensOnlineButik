using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KensOnlineButik.Startup))]
namespace KensOnlineButik
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
