using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace SuperRower.Models
{
    public class RowerPriceViewModel : Controller
    {
        public int RowerPriceID { get; set; }
        [DisplayName("Cena roweru za dzień")]
        public int Price { get; set; }
    }
}
