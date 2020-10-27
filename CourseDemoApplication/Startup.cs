using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CourseDemoApplication.Startup))]
namespace CourseDemoApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
