using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MadeyMvc.Startup))]
namespace MadeyMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
