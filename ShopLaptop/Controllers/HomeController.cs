﻿using ShopLaptop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopLaptop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HomeModel home = new HomeModel();
            return View(home);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Details()
        {
            return View();
        }
    }
}