using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HotelManagmentSystem1._1.Startup))]
namespace HotelManagmentSystem1._1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
