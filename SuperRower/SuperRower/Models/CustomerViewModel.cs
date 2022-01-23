using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace SuperRower.Models
{
    public class CustomerViewModel
    {

        public int CustomerID { get; set; }
        [DisplayName("Imię Klienta")]
        public string NameCustomer { get; set; }
        [DisplayName("Nazwisko Klienta")]
        public string LastNameCustomer { get; set; }
        [DisplayName("Numer telefonu")]
        public string TelCustomer { get; set; }
        [DisplayName("Miasto")]
        public string CityAdressCustomer { get; set; }
        [DisplayName("Ulica")]
        public string StreetAdressCustomer { get; set; }
        [DisplayName("nr budynku")]
        public string BuildingAdressCustomer { get; set; }
        [DisplayName("nr mieszkania")]
        public string ApartmentAdressCustomer { get; set; }
        [DisplayName("kod pocztowy")]
        public string KodCustomer { get; set; }
        public List<TransactionViewModel> Rowery { get; set; }
    }
}
