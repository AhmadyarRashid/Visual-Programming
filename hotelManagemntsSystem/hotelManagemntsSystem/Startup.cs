using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hotelManagemntsSystem.Startup))]
namespace hotelManagemntsSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
