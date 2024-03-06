using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Exercise1_MVC.Startup))]
namespace Exercise1_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
