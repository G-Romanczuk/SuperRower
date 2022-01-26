using Microsoft.AspNetCore.Mvc;
using SuperRowerDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperRower.Controllers;
using SuperRower.Models;
using Microsoft.AspNetCore.Authorization;

namespace SuperRower.Controllers
{
  
        [Authorize]
        public class TransactionController : Controller
        {
            private readonly ITransactionRepository _transactionRepository;

            public TransactionController(
                                      ITransactionRepository transactionRepository)
            {
                _transactionRepository = transactionRepository;
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
            public IActionResult Add(SuperRowerDB.Transaction transaction)
            {

                _transactionRepository.Create(transaction);
                var bases = _transactionRepository.GetAll();


                return View("Index", bases);
            }
        }
    }


