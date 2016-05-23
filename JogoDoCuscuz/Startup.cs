using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JogoDoCuscuz.Startup))]
namespace JogoDoCuscuz
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
