using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SuperRower.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SuperRower.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

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

        [HttpGet]
        public ViewResult ContactForm()
        {
            return View();
        }


        [HttpPost]
        public ViewResult ContactForm(Contact contact)
        {
            //TODO utrwalić dane w systemie
            if (ModelState.IsValid)
            {
                return View("ConfirmContact", contact);
            }
            else
            {
                return View();
            }
        }

    }
}
