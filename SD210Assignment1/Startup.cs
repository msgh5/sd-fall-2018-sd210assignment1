using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SD210Assignment1.Startup))]
namespace SD210Assignment1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
