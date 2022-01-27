using Microsoft.AspNetCore.Mvc;
using System.Linq;
using SuperRowerDB;
using SuperRower.Models;
using Microsoft.AspNetCore.Authorization;

namespace SuperRower.Controllers

{
    [Authorize]
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IActionResult Index()
        {

            var bases = _customerRepository.GetAll();

            return View(bases);
        }

        public IActionResult Details(int id)
        {
            var dto = _customerRepository.GetAll().Where(x => x.CustomerID == id).FirstOrDefault();

            return View(dto);
        }

        public IActionResult Edit(int id)
        {
            var cus = _customerRepository.GetAll().Where(x => x.CustomerID == id).FirstOrDefault();
            

            return View(cus);
        }

        [HttpPost]
        public IActionResult Edit(CustomerViewModel customer)
        {
            var customerDb = new Customer
            {
                CustomerID = customer.CustomerID,
                NameCustomer = customer.NameCustomer,
                LastNameCustomer = customer.LastNameCustomer,
                TelCustomer = customer.TelCustomer,
                CityAdressCustomer = customer.CityAdressCustomer,
                StreetAdressCustomer = customer.StreetAdressCustomer,
                BuildingAdressCustomer = customer.BuildingAdressCustomer,
                ApartmentAdressCustomer = customer.ApartmentAdressCustomer,
                KodCustomer = customer.KodCustomer,
            };
            _customerRepository.Update(customerDb);
            return View(customerDb);
        }

        public IActionResult Delete(int id)
        {
          var x =  _customerRepository.GetById(id);
            _customerRepository.Delete(x);

            var bases = _customerRepository.GetAll();
            return View("Index", bases);
        }

        public IActionResult Add() => View();

        [HttpPost]
        public IActionResult Add(CustomerViewModel customer)
        {
           

            var customerDb = new Customer
            {
                CustomerID = customer.CustomerID,
                NameCustomer = customer.NameCustomer,
                LastNameCustomer = customer.LastNameCustomer,
                TelCustomer = customer.TelCustomer,
                CityAdressCustomer = customer.CityAdressCustomer,
                StreetAdressCustomer = customer.StreetAdressCustomer,
                BuildingAdressCustomer = customer.BuildingAdressCustomer,
                ApartmentAdressCustomer = customer.ApartmentAdressCustomer,
                KodCustomer = customer.KodCustomer,
            };
            _customerRepository.Create(customerDb);
            var bases = _customerRepository.GetAll();

           
            return View("Index", bases);
        }

        [HttpGet]
        public ViewResult PodziekowanieCustomer()
        {
            return View();
        }


        [HttpPost]
        public ViewResult PodziekowanieCustomer(SuperRowerDB.Customer contact)
        {
            //TODO utrwalić dane w systemie
            if (ModelState.IsValid)
            {
                return View("PodziekowanieCustomer", contact);
            }
            else
            {
                return View();
            }
        }
    }
}
