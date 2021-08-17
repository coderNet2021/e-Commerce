using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(onlineShoppingStore.Startup))]
namespace onlineShoppingStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
