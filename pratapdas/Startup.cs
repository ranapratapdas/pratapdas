using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pratapdas.Startup))]
namespace pratapdas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
