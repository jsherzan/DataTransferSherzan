﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DataTransferSherzan.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DataTransferSherzan.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

        }



        public IActionResult Index(string gameFilter = "All", string categoryFilter = "All")
        {
            FlagsModel model = new FlagsModel();
            model.gameFilter = gameFilter;
            model.categoryFilter = categoryFilter;
            return View(model);
        }

        public IActionResult Privacy(string gameFilter = "All", string categoryFilter = "All")
        {
            FlagsModel model = new FlagsModel();
            model.gameFilter = gameFilter;
            model.categoryFilter = categoryFilter;
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
