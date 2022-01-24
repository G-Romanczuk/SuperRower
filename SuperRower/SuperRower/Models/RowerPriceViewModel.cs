using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperRower.Models
{
    public class RowerPriceViewModel 
    {
        public int RowerPriceID { get; set; }
        [DisplayName("Cena roweru za dzień")]
        [Required(ErrorMessage = "Proszę podać cenę!")]
        [Range(1, 3000, ErrorMessage = "Proszę podać poprawną cenę!")]
        public int Price { get; set; }
    }
}
