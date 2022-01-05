using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UnderConstruction.Startup))]
namespace UnderConstruction
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
