using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CardinalTechOrgSite.Startup))]
namespace CardinalTechOrgSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
