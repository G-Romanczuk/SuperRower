using Microsoft.AspNetCore.Mvc;
using System.Linq;
using SuperRowerDB;
using SuperRower.Models;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using SuperRowerDB.Migrations;

namespace SuperRower.Controllers
{
    public class BuyController : Controller
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IRowerRentRepository _rowerRentRepository;
        private readonly IRowerPriceRepository _rowerPriceRepository;
        private readonly ITransactionRepository _transactionRepository;
        private readonly SuperRowerDbContext _db;

        public BuyController(ICustomerRepository customerRepository,
                                 IRowerRentRepository rowerRentRepository,
                                 IRowerPriceRepository rowerPriceRepository,
                                 ITransactionRepository transactionRepository,
                                   SuperRowerDbContext db)
        {
            _customerRepository = customerRepository;
            _rowerRentRepository = rowerRentRepository;
            _rowerPriceRepository = rowerPriceRepository;
            _transactionRepository = transactionRepository;
            _db = db;
        }

        List<Transaction> Transaction = new List<Transaction>();
        List<RowerRent> RowerRent = new List<RowerRent>();
        List<RowerPrice> RowerPrice = new List<RowerPrice>();

        List<Customer> Customer = new List<Customer>();


        public IActionResult Index()
        {

            var tr = _transactionRepository.GetAll();
            List<BuyViewModel> BuyViewModel = new List<BuyViewModel>();
            foreach (var item in tr)
            {
                
                var pr = _rowerPriceRepository.GetAll().Where(x => x.RowerPriceID == item.RowerPriceIF).FirstOrDefault();
                var ro = _rowerRentRepository.GetAll().Where(x => x.RowerRentID == item.RowerPriceIF).FirstOrDefault();
                item.RowerRent = ro;
                item.RowerPrice = pr;
                var buy = new BuyViewModel
                {
                    trans = item,
                    cena = item.RowerPrice,
                    typ = item.RowerRent
                    
                
                };
                BuyViewModel.Add(buy);

            }

            return View(BuyViewModel);


        }
          
    //        foreach (var d in data)
    //        {
    //            DateTime pocz = Convert.ToDateTime(d.start);
    //    DateTime kon = Convert.ToDateTime(d.end);
    //    TimeSpan diff = kon - pocz;
    //}
    

   

}

}
