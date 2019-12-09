using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lecture19___ASP.NET.Startup))]
namespace Lecture19___ASP.NET
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
