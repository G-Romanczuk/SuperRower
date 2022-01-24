using Microsoft.AspNetCore.Mvc;
using SuperRowerDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperRower.Controllers;
using SuperRower.Models;

namespace SuperRower.Controllers
{
  

        public class TransactionController : Controller
        {
            private readonly ICustomerRepository _customerRepository;
            private readonly IRowerRentRepository _rowerRentRepository;
            private readonly IRowerPriceRepository _rowerPriceRepository;
            private readonly ITransactionRepository _transactionRepository;
            private readonly IServiceProvider _serviceProvider;

            public TransactionController(ICustomerRepository customerRepository,
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

                var bases = _transactionRepository.GetAll();

                return View(bases);
            }

            public IActionResult Details(int id)
            {
                var dto = _transactionRepository.GetAll().Where(x => x.TransactionID == id).FirstOrDefault();

                return View(dto);
            }

            public IActionResult Edit(int id)
            {
                var cus = _transactionRepository.GetAll().Where(x => x.TransactionID == id).FirstOrDefault();


                return View(cus);
            }

            [HttpPost]
            public IActionResult Edit(TransactionViewModel transaction)
            {
                var transactionDb = new Transaction
                {
                    TransactionID = transaction.TransactionID,
                    StartDate = transaction.StartDate,
                    EndDate = transaction.EndDate

                };
                _transactionRepository.Update(transactionDb);
                return View(transactionDb);
            }

            public IActionResult Delete(int id)
            {
                var x = _transactionRepository.GetById(id);
                _transactionRepository.Delete(x);

                var bases = _transactionRepository.GetAll();
                return View("Index", bases);
            }

            public IActionResult Add() => View();

            [HttpPost]
            public IActionResult Add(TransactionViewModel transaction)
            {


                var transactionDb = new Transaction
                {
                    TransactionID = transaction.TransactionID,
                    StartDate = transaction.StartDate,
                    EndDate = transaction.EndDate
                };
                _transactionRepository.Create(transactionDb);
                var bases = _transactionRepository.GetAll();


                return View("Index", bases);
            }
        }
    }


