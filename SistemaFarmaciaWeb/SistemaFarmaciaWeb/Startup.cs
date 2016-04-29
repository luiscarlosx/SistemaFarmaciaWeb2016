using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemaFarmaciaWeb.Startup))]
namespace SistemaFarmaciaWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
