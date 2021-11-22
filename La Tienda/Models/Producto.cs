using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace La_Tienda.Models
{
    public class Producto
    {
        private int Codigo;
        private string Descripcion;
        private float Costo;
        private int MargenDeGanancia;
        private int PorcentajeIva;
        private float Iva;
        private float NetoGravado;
        private float PrecioDeVenta;

        private Marca Marca;
        private Rubro Rubro;

        public Producto(int codigo, string descripcion, float costo, int margenDeGanancia, int porcentajeIva)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Costo = costo;
            MargenDeGanancia = margenDeGanancia;
            PorcentajeIva = porcentajeIva;
        }

        public Producto(int codigo, string descripcion, float costo, int margenDeGanancia, int porcentajeIva, Marca marca, Rubro rubro) : this(codigo, descripcion, costo, margenDeGanancia, porcentajeIva)
        {
            Marca = marca;
            Rubro = rubro;
            CalcularNetoGravado();
            CalcularIva();
            CalcularPrecioDeVenta();
        }

        public int Codigo1 { get => Codigo; set => Codigo = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
        public float Costo1 { get => Costo; set => Costo = value; }
        public int MargenDeGanancia1 { get => MargenDeGanancia; set => MargenDeGanancia = value; }
        public int PorcentajeIva1 { get => PorcentajeIva; set => PorcentajeIva = value; }
        public float Iva1 { get => Iva; set => Iva = value; }
        public float NetoGravado1 { get => NetoGravado; set => NetoGravado = value; }
        public float PrecioDeVenta1 { get => PrecioDeVenta; set => PrecioDeVenta = value; }
        public Marca Marca1 { get => Marca; set => Marca = value; }
        public Rubro Rubro1 { get => Rubro; set => Rubro = value; }

        public void CalcularNetoGravado()
        {
            NetoGravado = Costo + Costo * MargenDeGanancia / 100;
        }

        public void CalcularIva()
        {
            Iva = NetoGravado * PorcentajeIva / 100;
        }

        public void CalcularPrecioDeVenta()
        {
            PrecioDeVenta = NetoGravado + Iva;
        }
    }
}