using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VagabondBasics.Startup))]
namespace VagabondBasics
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
