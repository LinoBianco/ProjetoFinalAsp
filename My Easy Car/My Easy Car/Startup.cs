using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(My_Easy_Car.Startup))]
namespace My_Easy_Car
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
