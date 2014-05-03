using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testRavenDB.Startup))]
namespace testRavenDB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
