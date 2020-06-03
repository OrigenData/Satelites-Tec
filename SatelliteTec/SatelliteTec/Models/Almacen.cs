using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SatelliteTec.Models
{
    public class Almacen
    {
        public int Id { get; set; }
        [Display(Name ="Estado")]
        [Required]
        public string Estado { get; set; }
    }
}