using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace SuperRower.Models
{
    public class Contact
    {

        [Required(ErrorMessage = "Proszę podać imię Klienta!")]
        [StringLength(20, ErrorMessage = "Proszę podać poprawne imię Klienta!")]
        public string NameCustomer { get; set; }
        [Required(ErrorMessage = "Proszę podać Nazwisko Klienta!")]
        [StringLength(30, ErrorMessage = "Proszę podać poprawne nazwisko Klienta!")]
        public string LastNameCustomer { get; set; }
        [Required(ErrorMessage = "Proszę podać  numer telefonu Klienta!")]
        [Phone(ErrorMessage = "Proszę podać poprawny numer telefonu Klienta!")]
        public string TelCustomer { get; set; }
        [Required(ErrorMessage = "Proszę podać nazwę miasta Klienta!")]
        [MinLength(length: 2, ErrorMessage = "Proszę podać poprawną nazwę miasta Klienta!")]
        public string CityAdressCustomer { get; set; }
        [Required(ErrorMessage = "Proszę podać poprawną nazwę ulicy Klienta!")]
        [MaxLength(length: 50, ErrorMessage = "Proszę podać poprawną nazwę ulicy Klienta!")]
        public string StreetAdressCustomer { get; set; }
        [Required(ErrorMessage = "Proszę podać numer budynku Klienta!")]
        [Range(1, 3000, ErrorMessage = "Proszę podać poprawny numer budynku Klienta!")]
        public string BuildingAdressCustomer { get; set; }
        [Range(1, 300, ErrorMessage = "Proszę podać poprawny numer mieszkania Klienta!")]
        public string ApartmentAdressCustomer { get; set; }
        [Required(ErrorMessage = "Proszę podać kod pocztowy Klienta!")]
        [RegularExpression("[0-9]{2}-[0-9]{3}", ErrorMessage = "Proszę podać poprawny kod pocztowy Klienta!")]
        public string KodCustomer { get; set; }
        public string Model { get; set; }
        [Required(ErrorMessage = "Proszę podać datę wypożyczenia Roweru!")]
        public string StartDate { get; set; }
        [Required(ErrorMessage = "Proszę podać datę oddania Roweru!")]
        public string EndDate { get; set; }

        
       



    }

}
