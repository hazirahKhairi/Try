using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InterfaceDotnet.Startup))]
namespace InterfaceDotnet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
