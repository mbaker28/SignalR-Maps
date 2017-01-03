using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignalR_Maps.Startup))]
namespace SignalR_Maps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            FileWatcher.init();
            app.MapSignalR();
        }
    }
}
