using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestVSMVC.Startup))]
namespace TestVSMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
