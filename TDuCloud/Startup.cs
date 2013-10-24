using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TDuCloud.Startup))]
namespace TDuCloud
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
