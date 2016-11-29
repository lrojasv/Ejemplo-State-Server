using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EjemploStateServer.Startup))]
namespace EjemploStateServer
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
