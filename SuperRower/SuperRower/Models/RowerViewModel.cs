using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace SuperRower.Models
{
        public class RowerViewModel
        {
            public int RowerRentID { get; set; }
            [DisplayName("Nazwa Roweru")]
            public string Model { get; set; }
            [DisplayName("Producent")]
            public string Producent { get; set; }
            [DisplayName("Kraj produkcji")]
        public string Country { get; set; }
        [DisplayName("Rok produkcji")]
        public string Year { get; set; }
        [DisplayName("Typ roweru")]
        public string Type { get; set; }
    }
    }