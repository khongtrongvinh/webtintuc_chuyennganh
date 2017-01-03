using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(weptintuc.Startup))]
namespace weptintuc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
