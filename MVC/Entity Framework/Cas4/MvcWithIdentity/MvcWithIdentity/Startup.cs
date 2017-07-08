using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcWithIdentity.Startup))]
namespace MvcWithIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
