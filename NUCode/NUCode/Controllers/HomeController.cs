﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NUCode.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "NUCode Neumonteers";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "NUCode Neumonteers";

            return View();
        }
    }
}