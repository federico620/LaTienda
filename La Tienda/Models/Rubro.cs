using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace La_Tienda.Models
{
    public class Rubro
    {
        private String Descripcion;

        public Rubro()
        {
        }

        public Rubro(String Descripcion)
        {
            this.Descripcion = Descripcion;
        }

        public string Descripcion1 { get; set; }
       
    }
}