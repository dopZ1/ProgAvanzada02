using System;
using System.Collections.Generic;
using System.Text;

namespace ProgAvanzada02
{
    class Producto
    {
        public static List<Producto> productos = new List<Producto>();

        int id { set; get; }
        string nombre { set; get; }
        string descripcion { set; get; }
        double precio { set; get; }
        int cantidad { set; get; }

        public Producto(int id, string nombre, string descripcion, double precio, int cantidad)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        public static void AddProducto(int id, string nombre, string descripcion, double precio, int cantidad)
        {
            if (!VerificarId(id))
            {
                productos.Add(new Producto(id, nombre, descripcion, precio, cantidad));
                Console.WriteLine("Producto Agregado!\n");
            }
            else
            {
                Console.WriteLine("Producto ya existe!\n");
            }

        }

        public static void DelProducto(int id)
        {
            if(NotNull())
            {
                if (VerificarId(id))
                {
                    foreach (var prod in productos)
                    {
                        if (id.Equals(prod.id))
                        {
                            productos.Remove(prod);
                            Console.WriteLine("Producto Eliminado!\n");
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Producto no Encontrado!\n");
                }

            }
        }

        public static void ModProducto(int id, string nombre, string descripcion, double precio)
        {
            if (NotNull())
            {
                foreach (var p in productos)
                {
                    if (id.Equals(p.id))
                    {
                        Console.Write($"Nombre: {p.nombre}\nDescripcion: {p.descripcion}\nPrecio: {p.precio}");
                        p.nombre = nombre;
                        p.descripcion = descripcion;
                        p.precio = precio;
                    } 
                    else
                    {
                        Console.WriteLine("Producto no Encontrado");
                    }
                }
                Console.WriteLine("Producto Modificado!\n");
            }
        }

        public static void ListProducto()
        {
            foreach (var p in productos)
            {
                Console.WriteLine($"ID: {p.id}\nNombre: {p.nombre}\nDescripcion: {p.descripcion}\nPrecio: {p.precio}\nCantidad: {p.cantidad}\n");
            }
        }

        protected static bool NotNull()
        {
            if (productos.Count > 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("\nIngrese Productos Primero\n");
                return false;
            }
        }

        private static bool VerificarId(int id)
        {
            foreach (var c in productos)
            {
                if (id.Equals(c.id))
                {
                    return true;
                }
            }
            return false;
        }

        public static double CalcTotal(int id_p, int can_p)
        {
            double total = 0;
            foreach (var p in productos)
            {
                if (id_p.Equals(p.id))
                {
                    total = p.precio;
                }
            }
            return total * can_p;
        }
    }
}