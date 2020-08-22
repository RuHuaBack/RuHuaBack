using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RunHuaAdmin.Startup))]
namespace RunHuaAdmin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
