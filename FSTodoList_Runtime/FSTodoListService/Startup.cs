using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(FSTodoListService.Startup))]

namespace FSTodoListService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}