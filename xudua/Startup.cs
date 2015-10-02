using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(xudua.Startup))]
namespace xudua
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
