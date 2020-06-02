using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SatelliteTec.Models
{
    public class Visit
    {
        public int Id { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        public string Descripcion { get; set; }

    }
}