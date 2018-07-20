using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Newtonsoft.Json;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Dapper;
using System.Configuration;

namespace PTrackApp.Controllers
{
    public class HomeController : Controller
    {
        private IDbConnection _data;
        public HomeController()
        {
            _data = new SqlConnection(ConfigurationManager.ConnectionStrings["PCodeTrackDataBase"].ConnectionString);
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Index()
        {
            ViewBag.Title = "PCODE TRACK";
            return View();
        }
    }
}