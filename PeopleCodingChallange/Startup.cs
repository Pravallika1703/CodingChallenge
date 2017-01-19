using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PeopleCodingChallange.Startup))]
namespace PeopleCodingChallange
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
