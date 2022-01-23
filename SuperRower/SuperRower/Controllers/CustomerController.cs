﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperRowerDB;
using SuperRower.Models;

namespace SuperRower.Controllers
    
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IRowerRentRepository _rowerRentRepository;
        private readonly IRowerPriceRepository _rowerPriceRepository;
        private readonly ITransactionRepository _transactionRepository;
        private readonly IServiceProvider _serviceProvider;

        public CustomerController(ICustomerRepository customerRepository,
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
            var bases = _customerRepository.GetAll();
            return View();
        }

        public IActionResult Details(int id)
        {
            var dto = _customerRepository.GetAll().Where(x => x.CustomerID == id).FirstOrDefault();

            return View();
        }

        public IActionResult Edit(int id)
        {
            var cus = _customerRepository.GetAll().Where(x => x.CustomerID == id).FirstOrDefault();

            return View("");
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
            return View("");
        }

        public IActionResult Delete(CustomerViewModel customer)
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
            _customerRepository.Delete(customerDb);
            return View("");
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
            return View("");
        }
    }
}
