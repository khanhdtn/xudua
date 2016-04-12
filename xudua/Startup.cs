using Microsoft.Owin;
using Owin;
using XuDua;

[assembly: OwinStartup(typeof(Startup))]
namespace XuDua
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
