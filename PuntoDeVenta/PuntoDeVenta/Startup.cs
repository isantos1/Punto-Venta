using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PuntoDeVenta.Startup))]
namespace PuntoDeVenta
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
