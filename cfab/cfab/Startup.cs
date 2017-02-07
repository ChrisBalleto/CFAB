using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cfab.Startup))]
namespace cfab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
