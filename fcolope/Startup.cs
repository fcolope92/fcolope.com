using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(fcolope.Startup))]
namespace fcolope
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
