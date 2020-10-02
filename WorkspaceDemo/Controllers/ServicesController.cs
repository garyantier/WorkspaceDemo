using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkspaceDemo.Models;

namespace WorkspaceDemo.Controllers.API
{
    public class ServicesController : Controller
    {
        // GET: Services
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Browse()
        {
            var services = Services.Browse();
            return Json(services, JsonRequestBehavior.AllowGet);
        }
    }
}