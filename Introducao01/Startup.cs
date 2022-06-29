using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Introducao01.Startup))]
namespace Introducao01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
