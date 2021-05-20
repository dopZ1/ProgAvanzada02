using System;
using System.Collections.Generic;
using System.Text;

namespace ProgAvanzada02
{
    class Carrito
    {
        public static List<Carrito> carrito = new List<Carrito>();

        public int idProducto { get; set; }
        public int cantidad { get; set; }

        public Carrito(int idProducto, int cantidad)
        {
            this.idProducto = idProducto;
            this.cantidad = cantidad;
        }

        public static void CreateCarrito(int id, int cant)
        {
            if (Producto.IdExists(id)){
                carrito.Add(new Carrito(id, cant));
                Console.WriteLine("Producto Agregado!\n");
            } else
            {
                Console.WriteLine("El Producto no existe!");
            }
        }

        public static void ReadCarrito()
        {
            if (NotEmpty())
            {
                foreach (var c in carrito)
                {
                    Console.WriteLine($"ID: {c.idProducto}\nCantidad: {c.cantidad}\n");
                }
            } else {
                Console.WriteLine("Carrito Vacio!");
            }
        }

        public static void DeleteCarrito(int id)
        {
            if (NotEmpty())
            {
                foreach (var c in carrito)
                {
                    if (c.idProducto.Equals(id))
                    {
                        carrito.Remove(c);
                        Console.WriteLine("Producto eliminado del Carrito!");
                    }
                }
            } else {
                Console.WriteLine("Carrito Vacio!");
            }
        }

        public static string CalcTotal()
        {
            if (NotEmpty())
            {
                string output = "";
                double total = 0;
                foreach (var c in carrito)
                {
                    foreach (var p in Producto.productos)
                    {
                        if (p.id.Equals(c.idProducto))
                        {                
                            output += $"Nombre: {p.nombre} Precio: {p.precio} Cantidad: {c.cantidad}\n";
                            total = total + p.precio * c.cantidad;
                        }
                    }
                }
                return output + "$" + total;
            } else {
                Console.WriteLine("Carrito Vacio!");
            }
            return "";
        }

        public static double CalcUnitario(int idProducto, int cantidad)
        {
            double total = 0;
            if (NotEmpty())
            {
                foreach (var p in Producto.productos)
                {
                    if (p.id.Equals(idProducto))
                    {                
                        total = p.precio * cantidad;
                    }
                }
            }

            return total;
        }

        public static bool NotEmpty()
        {
            if (carrito.Count > 0)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
