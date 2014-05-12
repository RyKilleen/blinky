using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Blinky.Startup))]
namespace Blinky
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
