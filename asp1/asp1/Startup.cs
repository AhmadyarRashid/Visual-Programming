using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(asp1.Startup))]
namespace asp1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
