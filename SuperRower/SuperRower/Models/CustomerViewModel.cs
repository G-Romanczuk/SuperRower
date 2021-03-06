using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperRower.Models
{
    public class CustomerViewModel
    {

        public int CustomerID { get; set; }
        [DisplayName("Imię Klienta")]
        [StringLength(20, ErrorMessage = "Proszę podać poprawne imię Klienta!")]
        [Required(ErrorMessage = "Proszę podać imię Klienta!")]
        public string NameCustomer { get; set; }
        [DisplayName("Nazwisko Klienta")]
        [Required(ErrorMessage = "Proszę podać Nazwisko Klienta!")]
        [StringLength(30, ErrorMessage = "Proszę podać poprawne nazwisko Klienta!")]
        public string LastNameCustomer { get; set; }
        [DisplayName("Numer telefonu")]
        [Required(ErrorMessage = "Proszę podać  numer telefonu Klienta!")]
        [Phone(ErrorMessage = "Proszę podać poprawny numer telefonu Klienta!")]
        [StringLength(9, ErrorMessage = "Proszę podać poprawne imię Klienta!")]
        public string TelCustomer { get; set; }
        [DisplayName("Miasto")]
        [Required(ErrorMessage = "Proszę podać nazwę miasta Klienta!")]
        [MinLength(length: 2, ErrorMessage = "Proszę podać poprawną nazwę miasta Klienta!")]
        public string CityAdressCustomer { get; set; }
        [DisplayName("Ulica")]
        [Required(ErrorMessage = "Proszę podać poprawną nazwę ulicy Klienta!")]
        [MaxLength(length: 50, ErrorMessage = "Proszę podać poprawną nazwę ulicy Klienta!")]
        public string StreetAdressCustomer { get; set; }
        [DisplayName("nr budynku")]
        [Required(ErrorMessage = "Proszę podać numer budynku Klienta!")]
        [Range(1, 3000, ErrorMessage = "Proszę podać poprawny numer budynku Klienta!")]
        public string BuildingAdressCustomer { get; set; }
        [DisplayName("nr mieszkania")]
        [Range(1, 300, ErrorMessage = "Proszę podać poprawny numer mieszkania Klienta!")]
        public string ApartmentAdressCustomer { get; set; }
        [DisplayName("kod pocztowy")]
        [Required(ErrorMessage = "Proszę podać kod pocztowy Klienta!")]
        [RegularExpression("[0-9]{2}-[0-9]{3}", ErrorMessage = "Proszę podać poprawny kod pocztowy Klienta!")]
        public string KodCustomer { get; set; }
        public List<TransactionViewModel> Rowery { get; set; }
    }
}
