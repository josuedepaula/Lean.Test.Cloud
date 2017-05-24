using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lean.Test.Cloud.Startup))]
namespace Lean.Test.Cloud
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
