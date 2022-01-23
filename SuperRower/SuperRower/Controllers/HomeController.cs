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

        private static List<Contact> _contacts = new List<Contact>()
{
    new Contact()
    {
         NameCustomer = "Adam", LastNameCustomer = "Nowak",
          TelCustomer = "503562703",  CityAdressCustomer = "Adam",
           StreetAdressCustomer = "Adam", BuildingAdressCustomer = "Adam",
           ApartmentAdressCustomer = "Adam", KodCustomer = "Adam", Model = "jeden",
        StartDate = "2020-10-23", EndDate = "2020-10-24"
        }
};


    }
}
