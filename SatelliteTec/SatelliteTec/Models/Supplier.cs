using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SatelliteTec.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        [Display(Name="Nombre")]
        [Required]
        public string Name { get; set; }
        [Display(Name="Telefono")]
        [Required]
        public string Phone { get; set; }
        [Display(Name="Correo Electronico")]
        public string Email { get; set; }

    }
}