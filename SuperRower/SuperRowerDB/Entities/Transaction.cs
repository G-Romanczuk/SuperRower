using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperRowerDB
{
    public class Transaction
    {
       
        public int TransactionID { get; set; }
        [ForeignKey("Customer")]
        [Required(ErrorMessage = "Proszę podać numer Klienta!")]
        [Range(1, 50, ErrorMessage = "Proszę podać poprawny numer Klienta!")]
        public int CustomerIF { get; set; }
        public virtual Customer Customer { get; set; }
        [ForeignKey("RowerPrice")]
        [Required(ErrorMessage = "Proszę podać numer roweru!")]
        [Range(1, 4, ErrorMessage = "Proszę podać poprawny numer roweru!")]
        public int RowerPriceIF { get; set; }
        public virtual RowerPrice RowerPrice { get; set; }
        [ForeignKey("RowerRent")]
        [Required(ErrorMessage = "Proszę podać numer ceny roweru!")]
        [Range(1, 4, ErrorMessage = "Proszę podać poprawny numer ceny roweru!")]
        public int RowerRentIF { get; set; }
        public virtual RowerRent RowerRent { get; set; }
        [Required(ErrorMessage = "Proszę podać datę rozpoczęcia wynajmu!")]
        public string StartDate { get; set; }
        [Required(ErrorMessage = "Proszę podać datę Zakończenia wynajmu!")]
        
        public string EndDate { get; set; }
    }
}
