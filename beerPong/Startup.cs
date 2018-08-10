using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(beerPong.Startup))]
namespace beerPong
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
