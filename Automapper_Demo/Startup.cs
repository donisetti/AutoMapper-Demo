using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Automapper_Demo.Startup))]
namespace Automapper_Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
