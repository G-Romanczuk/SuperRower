using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperRower.Models
{
    public class TransactionViewModel 
    {
        public int TransactionID { get; set; }
        public int RowerPrice { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public CustomerViewModel Customer { get; set; }
        public RowerViewModel PackagePrice { get; set; }
        public RowerPriceViewModel PackageType { get; set; }
      
    }
}
