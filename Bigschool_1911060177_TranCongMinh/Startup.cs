using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bigschool_1911060177_TranCongMinh.Startup))]
namespace Bigschool_1911060177_TranCongMinh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
