using Microsoft.AspNetCore.Mvc;
using System.Linq;
using SuperRowerDB;
using SuperRower.Models;
using Microsoft.AspNetCore.Authorization;
using System;
using SuperRowerDB.Migrations;

namespace SuperRower.Models
{
    public class BuyViewModel 
    {
        public Transaction trans { get; set; }
        public RowerRent typ { get; set; }
        public RowerPrice cena { get; set; }


    }
}
