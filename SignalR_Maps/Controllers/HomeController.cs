﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SignalR_Maps.Hubs;
namespace SignalR_Maps.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            //MapsHub obj = new MapsHub();

            return View();
        }

    }
}