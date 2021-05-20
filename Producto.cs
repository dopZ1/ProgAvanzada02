using System;
using System.Collections.Generic;
using System.Text;

namespace ProgAvanzada02
{
    class Producto
    {
        public static List<Producto> productos = new List<Producto>();

        public int id { set; get; }
        public string nombre { set; get; }
        public string descripcion { set; get; }
        public double precio { set; get; }
        public int cantidad { set; get; }

        public Producto(int id, string nombre, string descripcion, double precio, int cantidad)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        public static void CreateProducto(int id, string nombre, string descripcion, double precio, int cantidad)
        {
            if (!IdExists(id))
            {
                productos.Add(new Producto(id, nombre, descripcion, precio, cantidad));
                Console.WriteLine("Producto Agregado!\n");
            } else
            {
                Console.WriteLine("Producto ya existe!\n");
            }
        }

        public static void ReadProductos()
        {
            if (NotNull())
            {
                foreach (var p in productos)
                {
                    Console.WriteLine($"ID: {p.id}\nNombre: {p.nombre}\nDescripcion: {p.descripcion}\nPrecio: {p.precio}\nStock: {p.cantidad}\n");
                }
            }
        }

        public static void UpdateProducto(int id, string nombre, string descripcion, double precio)
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
                    } else
                    {
                        Console.WriteLine("Producto no Encontrado");
                    }
                }
                Console.WriteLine("Producto Modificado!\n");
            }
        }

        public static void DeleteProducto(int id)
        {
            if(NotNull())
            {
                if (IdExists(id))
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
                } else
                {
                    Console.WriteLine("Producto no Encontrado!\n");
                }
            }
        }

        public static bool IdExists(int id)
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

        protected static bool NotNull()
        {
            if (productos.Count > 0)
            {
                return true;
            } else
            {
                Console.WriteLine("\nIngrese Productos Primero\n");
                return false;
            }
        }
    }
}