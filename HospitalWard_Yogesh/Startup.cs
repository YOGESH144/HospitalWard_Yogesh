using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HospitalWard_Yogesh.Startup))]
namespace HospitalWard_Yogesh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
