using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProgAvanzada02
{
    class Boleta
    {
        int idVendedor { get; set; }
        int idcliente { get; set; }
        int idProducto { get; set; }
        int cantidad { get; set; }
        double total { get; set; }

        public static async Task CreatePagoAsync(int pago)
        {

            Carrito.CalcTotal();

            if (Carrito.NotEmpty())
            {
                Console.Clear();

                Console.WriteLine("Esperando Pago");
                Console.WriteLine("*");
                await Task.Delay(250);
                Console.Clear();

                Console.WriteLine("Esperando Pago");
                Console.WriteLine(" *");
                await Task.Delay(250);
                Console.Clear();

                Console.WriteLine("Esperando Pago");
                Console.WriteLine("  *");
                await Task.Delay(250);
                Console.Clear();

                Console.WriteLine("Esperando Pago");
                Console.WriteLine("   *");
                await Task.Delay(250);
                Console.Clear();

                Console.WriteLine("Esperando Pago");
                Console.WriteLine("    *");
                await Task.Delay(250);
                Console.Clear();

                Console.WriteLine("Esperando Pago");
                Console.WriteLine("     *");
                await Task.Delay(250);
                Console.Clear();

                Console.WriteLine("Esperando Pago");
                Console.WriteLine("      *");
                await Task.Delay(250);
                Console.Clear();

                Console.WriteLine("Esperando Pago");
                Console.WriteLine("       *");
                await Task.Delay(250);
                Console.Clear();

                Console.WriteLine("Esperando Pago");
                Console.WriteLine("        *");
                await Task.Delay(250);
                Console.Clear();

                foreach (var c in Carrito.carrito)
                {
                    if (Stock.HaveStock(c.idProducto, c.cantidad))
                    {
                        Stock.DeleteStock(c.idProducto, c.cantidad);
                        Console.WriteLine($"Producto Pagado - ID: {c.idProducto} Total: {Carrito.CalcUnitario(c.idProducto, c.cantidad)}");
                    }
                }

                //Si hago remove en foreach de arriba no imprime todos los ConsoleWrite. SOLO POR ESTETICA DEJO 2
                foreach (var c in Carrito.carrito)
                {
                    Carrito.carrito.Remove(c);
                }
                    

                Console.Write("'Enter' para desplegar el Menu... ");
            }
            else
            {
                Console.WriteLine("Revise Stock de Productos faltantes!");
            }
        }

    }
}
