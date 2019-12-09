using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(modelToDbAsp.Startup))]
namespace modelToDbAsp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
