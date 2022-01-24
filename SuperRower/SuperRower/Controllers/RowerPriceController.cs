using Microsoft.AspNetCore.Mvc;
using SuperRower.Models;
using SuperRowerDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperRower.Controllers
{
    public class RowerPriceController : Controller
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IRowerRentRepository _rowerRentRepository;
        private readonly IRowerPriceRepository _rowerPriceRepository;
        private readonly ITransactionRepository _transactionRepository;
        private readonly IServiceProvider _serviceProvider;

        public RowerPriceController(ICustomerRepository customerRepository,
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

            var bases = _rowerPriceRepository.GetAll();

            return View(bases);
        }

        public IActionResult Details(int id)
        {
            var dto = _rowerPriceRepository.GetAll().Where(x => x.RowerPriceID == id).FirstOrDefault();

            return View(dto);
        }

        public IActionResult Edit(int id)
        {
            var cus = _rowerPriceRepository.GetAll().Where(x =>
            {
                return x.RowerPriceID == id;
            }).FirstOrDefault();


            return View(cus);
        }

        [HttpPost]
        public IActionResult Edit(RowerPriceViewModel rower)
        {
            var rowerPriceDb = new RowerPrice
            {
                RowerPriceID = rower.RowerPriceID,
                Price = rower.Price

            };
            _rowerPriceRepository.Update(rowerPriceDb);
            return View(rowerPriceDb);
        }

        public IActionResult Delete(int id)
        {
            var x = _rowerPriceRepository.GetById(id);
            _rowerPriceRepository.Delete(x);

            var bases = _rowerPriceRepository.GetAll();
            return View("Index", bases);
        }

        public IActionResult Add() => View();

        [HttpPost]
        public IActionResult Add(RowerPriceViewModel rower)
        {
            var rowerPriceDb = new RowerPrice
            {
                RowerPriceID = rower.RowerPriceID,
                Price = rower.Price

            };
            _rowerPriceRepository.Create(rowerPriceDb);

            var bases = _rowerPriceRepository.GetAll();


            return View("Index", bases);
        }
    }
}