using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitVsOnline.Startup))]
namespace GitVsOnline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
