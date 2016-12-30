using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureWebsite.Startup))]
namespace AzureWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
