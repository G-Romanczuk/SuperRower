using System;
using System.Collections.Generic;
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
        public int CustomerIF { get; set; }
        public virtual Customer Customer { get; set; }
        [ForeignKey("RowerPrice")]
        public int RowerPriceIF { get; set; }
        public virtual RowerPrice RowerPrice { get; set; }
        [ForeignKey("RowerRent")]
        public int RowerRentIF { get; set; }
        public virtual RowerRent RowerRent { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
