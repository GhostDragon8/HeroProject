using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HeroProject.Startup))]
namespace HeroProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
