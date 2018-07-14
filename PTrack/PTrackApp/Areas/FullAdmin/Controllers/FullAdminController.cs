using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PTrackApp.Areas.FullAdmin.Controllers
{
    public class FullAdminController : Controller
    {
        [HttpGet]
        public ActionResult Disboard()
        {
            return View();
        }
    }
}