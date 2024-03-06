using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Code1stMVC.Startup))]
namespace Code1stMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
