using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProblemaTeste.Startup))]
namespace ProblemaTeste
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
