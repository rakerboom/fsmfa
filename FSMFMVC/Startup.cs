using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FSMFMVC.Startup))]
namespace FSMFMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
