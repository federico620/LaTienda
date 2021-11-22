using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace La_Tienda.Models
{
    public class Stock
    {
        private int Cantidad;
        private Color Color;
        private Talle Talle;
        private Producto Producto;

        public Stock()
        {
        }

        public Stock(int cantidad, Color color, Talle talle, Producto producto)
        {
            Cantidad = cantidad;
            Color = color;
            Talle = talle;
            Producto = producto;
        }

        public int Cantidad1 { get => Cantidad; set => Cantidad = value; }
        public Color Color1 { get => Color; set => Color = value; }
        public Talle Talle1 { get => Talle; set => Talle = value; }
        public Producto Producto1 { get => Producto; set => Producto = value; }

        public void ActualizarStock(int cantidad)
        {
            this.Cantidad -= cantidad;
        }
    }
}