using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Umyang.Startup))]
namespace Umyang
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
