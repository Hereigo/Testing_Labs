using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Angular_Net462.Startup))]
namespace Angular_Net462
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
