using homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace homework.Controllers
{
    public class ReportController : Controller
    {
        客戶資料Entities db = new 客戶資料Entities();
        // GET: Report
        public ActionResult Index()
        {
            IQueryable<客戶總表> vm = db.客戶總表.AsQueryable();

            return View(vm);
        }
    }
}