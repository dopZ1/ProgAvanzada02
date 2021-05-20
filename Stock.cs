using System;
using System.Collections.Generic;
using System.Text;

namespace ProgAvanzada02
{
    class Stock
    {
        public static void CreateStock(int id, int cantidad)
        {
            foreach (var p in Producto.productos)
            {
                if (p.id.Equals(id))
                {
                    p.cantidad = p.cantidad + cantidad;
                }
            }
        }

        public static int DeleteStock(int id, int cantidad)
        {
            int cant = 0;
            foreach (var p in Producto.productos)
            {
                if (p.id.Equals(id))
                {
                    if (p.cantidad >= cantidad)
                    {
                        p.cantidad = p.cantidad - cantidad;
                        cant = p.cantidad;
                    }
                }
            }

            return cant;
        }

        public static bool HaveStock(int id, int cantidad)
        {
            foreach (var p in Producto.productos)
            {
                if (p.id.Equals(id))
                {
                    if (p.cantidad >= cantidad)
                    {
                        return true;
                    } else {
                        Console.WriteLine($"No hay Stock! ID: {p.id}");
                    }
                }
            }
            
            return false;
        }
    }
}
