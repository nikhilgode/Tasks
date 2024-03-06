using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodCatMVC.Startup))]
namespace FoodCatMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
