using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Online_Banking.Startup))]
namespace Online_Banking
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
