using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppAuth.Startup))]
namespace WebAppAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
