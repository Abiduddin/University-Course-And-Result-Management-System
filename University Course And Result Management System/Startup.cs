using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(University_Course_And_Result_Management_System.Startup))]
namespace University_Course_And_Result_Management_System
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
