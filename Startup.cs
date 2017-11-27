using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HerokuTest.Startup))]
namespace HerokuTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
