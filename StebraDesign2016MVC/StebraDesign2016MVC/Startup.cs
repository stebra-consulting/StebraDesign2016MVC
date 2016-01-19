using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StebraDesign2016MVC.Startup))]
namespace StebraDesign2016MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
