using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FilterPrac1st.Startup))]
namespace FilterPrac1st
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
