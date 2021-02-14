using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyAmigoPet.Startup))]
namespace MyAmigoPet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
