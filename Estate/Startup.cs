using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Estate.Startup))]
namespace Estate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
