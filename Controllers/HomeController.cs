﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TeplanConsultoria.Models;

namespace TeplanConsultoria.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
         HomeModel home = new HomeModel();
         home.nome = "Luis Branco";    
         home.email = "bpl_@outlook.com";
            return View(home);
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