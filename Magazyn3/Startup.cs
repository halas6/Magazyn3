using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Magazyn3.Startup))]
namespace Magazyn3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
