using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BikeCatMVC.Startup))]
namespace BikeCatMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
