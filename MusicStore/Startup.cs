using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OrderApp.Startup))]
namespace OrderApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
