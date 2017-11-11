using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lemon.Startup))]
namespace Lemon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
