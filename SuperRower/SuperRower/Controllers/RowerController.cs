using Microsoft.AspNetCore.Mvc;
using SuperRower.Models;
using SuperRowerDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperRower.Controllers
{
    public class RowerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IRowerRentRepository _rowerRentRepository;
        private readonly IRowerPriceRepository _rowerPriceRepository;
        private readonly ITransactionRepository _transactionRepository;
        private readonly IServiceProvider _serviceProvider;

        public RowerController(ICustomerRepository customerRepository,
                                 IRowerRentRepository rowerRentRepository,
                                 IRowerPriceRepository rowerPriceRepository,
                                  ITransactionRepository transactionRepository,
                                 IServiceProvider serviceProvider)
        {
            _customerRepository = customerRepository;
            _rowerRentRepository = rowerRentRepository;
            _rowerPriceRepository = rowerPriceRepository;
            _transactionRepository = transactionRepository;
            _serviceProvider = serviceProvider;
        }

        public IActionResult Index()
        {

            var bases = _rowerRentRepository.GetAll();

            return View(bases);
        }

        public IActionResult Details(int id)
        {
            var dto = _rowerRentRepository.GetAll().Where(x => x.RowerRentID == id).FirstOrDefault();

            return View(dto);
        }

        public IActionResult Edit(int id)
        {
            var cus = _rowerRentRepository.GetAll().Where(x => x.RowerRentID == id).FirstOrDefault();


            return View(cus);
        }

        [HttpPost]
        public IActionResult Edit(RowerViewModel rower)
        {
            var rowerRentDb = new RowerRent
            {
                RowerRentID = rower.RowerRentID,
                Model = rower.Model,
                Producent = rower.Producent,
                Country = rower.Country,
                Year = rower.Year,
                Type = rower.Type
                
            };
            _rowerRentRepository.Update(rowerRentDb);
            return View(rowerRentDb);
        }

        public IActionResult Delete(int id)
        {
            var x = _rowerRentRepository.GetById(id);
            _rowerRentRepository.Delete(x);

            var bases = _rowerRentRepository.GetAll();
            return View("Index", bases);
        }

        public IActionResult Add() => View();

        [HttpPost]
        public IActionResult Add(RowerViewModel rower)
        {
            var rowerRentDb = new RowerRent
            {
                RowerRentID = rower.RowerRentID,
                Model = rower.Model,
                Producent = rower.Producent,
                Country = rower.Country,
                Year = rower.Year,
                Type = rower.Type

            };
            _rowerRentRepository.Create(rowerRentDb);

            var bases = _rowerRentRepository.GetAll();


            return View("Index", bases);
        }
    }
}

