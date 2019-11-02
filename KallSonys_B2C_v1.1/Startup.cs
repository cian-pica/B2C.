using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KallSonys_B2C_v1._1.Startup))]
namespace KallSonys_B2C_v1._1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
