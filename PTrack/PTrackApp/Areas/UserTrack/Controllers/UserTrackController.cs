using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PTrackApp.Areas.UserTrack.Controllers
{
    public class UserTrackController : Controller
    {
        [HttpGet]
        public ActionResult Disboard()
        {
            return View();
        }
    }
}