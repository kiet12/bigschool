using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LeQuocKiet_1811062753.Startup))]
namespace LeQuocKiet_1811062753
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
