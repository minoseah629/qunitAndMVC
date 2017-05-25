using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QUnitMvcApp.Startup))]
namespace QUnitMvcApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
