﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Alfa.Controllers
{
    public class CupsController : Controller
    {
        // GET: Cups
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VM2018()
        {
            return View();
        }
    }
}