using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace La_Tienda.Models
{
    public class LineaDeVenta
    {
        private int cantidad;
        private float PrecioDeVenta;
        private Stock Stock;

        public LineaDeVenta()
        {
        }

        public LineaDeVenta(int cantidad, float precioDeVenta, Stock stock)
        {
            this.cantidad = cantidad;
            PrecioDeVenta = precioDeVenta;
            Stock = stock;
        }

        public int Cantidad { get => cantidad; set => cantidad = value; }
        public float PrecioDeVenta1 { get => PrecioDeVenta; set => PrecioDeVenta = value; }
        public Stock Stock1 { get => Stock; set => Stock = value; }

        public void AgregarProducto(Stock stock, int cantidad)
        {
            this.cantidad = cantidad;
            this.Stock = stock;
            this.PrecioDeVenta = stock.Producto1.PrecioDeVenta1;
            stock.ActualizarStock(cantidad);
        }
    }
}