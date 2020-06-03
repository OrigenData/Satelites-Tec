using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SatelliteTec.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name ="Serie")]
        [Required]
        public string Serie { get; set; }
        [Display(Name ="Activo")]
        [Required]
        public int Activo { get; set; }
        public Supplier supplier { get; set; }
        
    }
}