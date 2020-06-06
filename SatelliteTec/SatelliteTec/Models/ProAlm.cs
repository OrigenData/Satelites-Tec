using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace SatelliteTec.Models
{
    public class ProAlm
    {
        public int Id { get; set; }
        public Almacen Almacen { get; set; }
        public Product Product { get; set; }
    }
}