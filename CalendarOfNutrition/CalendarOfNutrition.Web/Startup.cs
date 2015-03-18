using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CalendarOfNutrition.Web.Startup))]
namespace CalendarOfNutrition.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
