using System.Web.Mvc;

namespace PTrackApp.Areas.FullAdmin
{
    public class FullAdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "FullAdmin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "FullAdmin_default",
                "FullAdmin/{controller}/{action}/{id}",
                new { action = "Disboard", controller = "FullAdmin", id = UrlParameter.Optional }
            );
        }
    }
}