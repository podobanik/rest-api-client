using RestApiClient.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common;
using Common.Extentions;

namespace RestApiClient.Controllers
{
    [Authorize]
    public class NewsController : Controller
    {
        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public ActionResult Index()
        {
            GosuslugiContext db = new GosuslugiContext();
            return View(db.Set<News>());
        }


        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public ActionResult GetXlsx()
        {
            var db = new GosuslugiContext();
            var xlsx = db.News.ToXlsx();

            return File(xlsx.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "News.xlsx");
        }
    }
}