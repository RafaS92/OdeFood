﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class RestaurantsController : Controller
    {
        // GET: Restarants
        public ActionResult Index()
        {
            return View();
        }
    }
}