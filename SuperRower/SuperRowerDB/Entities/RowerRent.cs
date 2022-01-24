using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperRowerDB
{
    public class RowerRent
    {
        public int RowerRentID { get; set; }
        [DisplayName("Nazwa Roweru")]
        [Required(ErrorMessage = "Proszę podać nazwę Roweru!")]
        [StringLength(20, ErrorMessage = "Proszę podać poprawną nazwę Roweru!")]
        public string Model { get; set; }
        [DisplayName("Producent")]
        [Required(ErrorMessage = "Proszę podać nazwę Producenta!")]
        [StringLength(20, ErrorMessage = "Proszę podać poprawną nazwę Producenta!")]
        public string Producent { get; set; }
        [DisplayName("Kraj produkcji")]
        [Required(ErrorMessage = "Proszę podać kraj produkcji!")]
        [MinLength(length: 2, ErrorMessage = "Proszę podać poprawny kraj produkcji!")]
        public string Country { get; set; }
        [DisplayName("Rok produkcji")]
        [Required(ErrorMessage = "Proszę podać rok produkcji!")]
        [Range(1920, 2021, ErrorMessage = "Proszę podać poprawny rok produkcji!")]
        public string Year { get; set; }
        [DisplayName("Typ roweru")]
        [MinLength(length: 3, ErrorMessage = "Proszę podać poprawny typ modelu!")]
        public string Type { get; set; }
    }
}
