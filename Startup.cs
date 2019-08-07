using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopInventory.Startup))]
namespace ShopInventory
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
