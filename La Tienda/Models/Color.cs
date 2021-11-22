using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace La_Tienda.Models
{
    public class Color
    {
        private string Descripcion;

        public Color(string descripcion)
        {
            Descripcion = descripcion;
        }

        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
    }
}