using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BugHero.Startup))]
namespace BugHero
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
