﻿using _The19Module.Services.Interfaces;
using _The19Module.Services.PerconServices;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using The_19_Module.Models;
using _19Module.Domain.Enums;

namespace The_19_Module.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
       

        public HomeController(ILogger<HomeController> logger, IPersonService personService)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}