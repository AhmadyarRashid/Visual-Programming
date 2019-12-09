using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lecture19.Startup))]
namespace Lecture19
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
