using Microsoft.Owin;
using Owin;
using TaskList.WebApi;

[assembly: OwinStartup(typeof(Startup))]

namespace TaskList.WebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
