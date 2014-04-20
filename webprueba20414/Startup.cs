using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webprueba20414.Startup))]
namespace webprueba20414
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
