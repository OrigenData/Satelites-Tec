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

        [Display(Name ="Fecha")]
        [Required]
        public DateTime Fecha { get; set; }
        [Display(Name ="Tipo de Consulta")]
        public string ConsultType { get; set; }
        [Display(Name ="Descripcion")]
        [Required]
        public string Descripcion { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
        public Supplier supplier { get; set; }
    }
}