using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TutorialMVC70486.Startup))]
namespace TutorialMVC70486
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
