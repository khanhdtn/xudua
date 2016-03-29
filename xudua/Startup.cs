using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XuDua.Startup))]
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
