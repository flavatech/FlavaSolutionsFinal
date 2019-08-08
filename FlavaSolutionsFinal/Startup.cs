using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FlavaSolutionsFinal.Startup))]
namespace FlavaSolutionsFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
