using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CoworkSpace.Web.Startup))]
namespace CoworkSpace.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
