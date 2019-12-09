using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lecture18___ASP.NET.Startup))]
namespace Lecture18___ASP.NET
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
