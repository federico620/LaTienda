using La_Tienda.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestLaTienda
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalcularNetoGravado()
        {
            //Configuracion

            var Producto = new Producto(5431,"Zapatilla Azul Nike",10000,15,21);

            //Ejecucion

            float Resultado = 11500;
            Producto.CalcularNetoGravado();

            //Comparacion

            Assert.AreEqual(Resultado, Producto.NetoGravado1);
        }

        [TestMethod]
        public void TestCalcularIva()
        {
            //Configuracion

            var Producto = new Producto(5431, "Zapatilla Azul Nike", 10000, 15, 21);
            Producto.CalcularNetoGravado();

            //Ejecucion

            float Resultado = 2415;
            Producto.CalcularIva();

            //Comparacion

            Assert.AreEqual(Resultado, Producto.Iva1);
        }

        [TestMethod]
        public void TestCalcularPrecioDeVenta()
        {
            //Configuracion

            var Producto = new Producto(5431, "Zapatilla Azul Nike", 10000, 15, 21);
            Producto.CalcularNetoGravado();
            Producto.CalcularIva();

            //Ejecucion

            float Resultado = 13915;
            Producto.CalcularPrecioDeVenta();

            //Comparacion

            Assert.AreEqual(Resultado, Producto.PrecioDeVenta1);
        }

        [TestMethod]
        public void TestActualizarStock()
        {
            //Configuracion

            var stock = new Stock();
            stock.Cantidad1 = 5;

            //Ejecucion

            int Resultado = 3;
            stock.ActualizarStock(2);

            //Comparacion

            Assert.AreEqual(Resultado, stock.Cantidad1);

        }

        [TestMethod]
        public void TestAgregarProductoConActualizacionDeStock()
        {
            //Configuracion

            var Producto = new Producto(5431, "Zapatilla Azul Nike", 10000, 15, 21);
            var stock = new Stock();
            stock.Cantidad1 = 5;
            stock.Producto1 = Producto;

            var Linea = new LineaDeVenta();

            //Ejecucion

            int ResultadoStock = 3;
            var ResultadoProducto = stock;
            Linea.AgregarProducto(stock, 2);

            //Comparacion

            Assert.AreEqual(ResultadoStock, stock.Cantidad1);
            Assert.AreEqual(ResultadoProducto, Linea.Stock1);
        }
    }
}
