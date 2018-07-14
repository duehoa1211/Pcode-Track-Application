using System.Web.Mvc;

namespace PTrackApp.Areas.UserTrack
{
    public class UserTrackAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "UserTrack";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "UserTrack_default",
                "youtrack/{controller}/{action}/{id}",
                new { action = "Disboard", controller = "UserTrack", id = UrlParameter.Optional }
            );
        }
    }
}