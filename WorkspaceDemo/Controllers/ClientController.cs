﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WorkspaceDemo.Controllers
{
    public class ClientsController : Controller
    {
        // GET: Client
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateModal()
        {
            return PartialView();
        }
    }
}