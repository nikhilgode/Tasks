using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RentalMovie.Startup))]
namespace RentalMovie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
