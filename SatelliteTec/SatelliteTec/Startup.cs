using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SatelliteTec.Startup))]
namespace SatelliteTec
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
