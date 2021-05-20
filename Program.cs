using System;
using System.Collections.Generic;
using ProgAvanzada02;

namespace ProgAvanzada02
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            bool o = false;

            Producto.CreateProducto(10, "Frugele Amarillo", "Frugele sabor Platano", 50, 1000);
            Producto.CreateProducto(20, "Frugele Rojo", "Frugele sabor Frambuesa", 60, 1000);
            Producto.CreateProducto(30, "Frugele Naranjo", "Frugele sabor Damasco", 40, 1000);
            Producto.CreateProducto(40, "Frugele Morado", "Frugele sabor Guinda", 45, 1000);
            Producto.CreateProducto(50, "Frugele Verde Oscuro", "Frugele sabor Manzana", 55, 1000);
            Producto.CreateProducto(60, "Frugele Verde Claro", "Frugele sabor Lima Limon", 40, 1000);

            //1 = Admin || 2 = Cliente
            Usuario.CreateUser(10, "Diego", "Pavez", 1, "Apoquindo 666", 1);
            Usuario.CreateUser(20, "Natalia", "Aguilera", 2, "Apoquindo 666", 2);

            Console.Clear();

            try
            {
                while (!o)
                {
                    Console.WriteLine("Seleccione una opcion:" +
                        "\n______________________________________" +
                        "\nProductos:" +
                        "\n______________________________________" +
                        "\n1. Agregar Producto" +
                        "\n2. Modificar Producto" +
                        "\n3. Eliminar Producto" +
                        "\n4. Listar Productos" +
                        "\n______________________________________" +
                        "\nClientes:" +
                        "\n______________________________________" +
                        "\n5. Agregar Cliente" +
                        "\n6. Modificar Cliente" +
                        "\n7. Eliminar Cliente" +
                        "\n8. Listar Clientes" +
                        "\n______________________________________" +
                        "\nCarrito:" +
                        "\n______________________________________" +
                        "\n9. Agregar a Carrito" +
                        "\n10. Eliminar del Carrito" +
                        "\n11. Mostrar Carrito" +
                        "\n______________________________________" +
                        "\nBoleta:" +
                        "\n______________________________________" +
                        "\n12. Generar Boleta" +
                        "\n13. Pagar Boleta" +
                        "\n14. Salir...");

                    option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("\nAgregar Producto\n______________________________________");

                            Console.Write("Ingrese ID del Producto: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Ingrese Nombre del Producto: ");
                            string nombre = Console.ReadLine().ToString();
                            Console.Write("Ingrese Descripcion del Producto: ");
                            string descripcion = Console.ReadLine().ToString();
                            Console.Write("Ingrese Precio del Producto: ");
                            double precio = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Ingrese Cantidad del Producto: ");
                            int cantidad = Convert.ToInt32(Console.ReadLine());

                            Producto.CreateProducto(id, nombre, descripcion, precio, cantidad);

                            WaitInput();
                            break;

                        case 2:
                            Console.WriteLine("\nModificar Producto\n______________________________________");

                            Console.Write("Ingrese ID del Producto: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Ingrese Nombre del Producto: ");
                            nombre = Console.ReadLine().ToString();
                            Console.Write("Ingrese Descripcion del Producto: ");
                            descripcion = Console.ReadLine().ToString();
                            Console.Write("Ingrese Precio del Producto: ");
                            precio = Convert.ToDouble(Console.ReadLine());

                            Producto.UpdateProducto(id, nombre, descripcion, precio);

                            WaitInput();
                            break;

                        case 3:
                            Console.WriteLine("\nEliminar Producto\n______________________________________");

                            Console.Write("Ingrese ID del producto para Eliminar: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            Producto.DeleteProducto(id);

                            WaitInput();
                            break;

                        case 4:
                            Console.WriteLine("\nListar Productos\n______________________________________");

                            Producto.ReadProductos();

                            WaitInput();
                            break;

                        case 5:
                            Console.WriteLine("\nAgregar Cliente\n______________________________________");

                            Console.Write("Ingrese ID del Cliente: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Ingrese Nombre del Cliente: ");
                            nombre = Console.ReadLine().ToString();
                            Console.Write("Ingrese Descripcion del Cliente: ");
                            string apellido = Console.ReadLine().ToString();
                            Console.Write("Ingrese RUT del Cliente: ");
                            int rut = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Ingrese Direccion del Cliente: ");
                            string direccion = Console.ReadLine().ToString();
                            Console.Write("Ingrese Tipo de Cliente: ");
                            byte tipo = Convert.ToByte(Console.ReadLine());

                            Usuario.CreateUser(id, nombre, apellido, rut, direccion, tipo);

                            WaitInput();
                            break;

                        case 6:
                            Console.WriteLine("\nModificar Cliente\n______________________________________");

                            Console.Write("Ingrese ID del Cliente: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Ingrese Nombre del Cliente: ");
                            nombre = Console.ReadLine().ToString();
                            Console.Write("Ingrese Apellido del Cliente: ");
                            apellido = Console.ReadLine().ToString();
                            Console.Write("Ingrese RUT del Cliente: ");
                            rut = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Ingrese Direccion del Cliente: ");
                            direccion = Console.ReadLine().ToString();
                            Console.Write("Ingrese Tipo de Cliente: ");
                            tipo = Convert.ToByte(Console.ReadLine());

                            Usuario.UpdateUser(id, nombre, apellido, rut, direccion, tipo);

                            WaitInput();
                            break;
                        case 7:
                            Console.WriteLine("\nEliminar Usuario\n______________________________________");

                            Console.Write("Ingrese RUT del Usuario para Eliminar: ");
                            rut = Convert.ToInt32(Console.ReadLine());
                            Usuario.DeleteUser(rut);

                            WaitInput();
                            break;

                        case 8:
                            Console.WriteLine("\nListar Usuarios\n______________________________________");

                            Usuario.ReadUsers();

                            WaitInput();
                            break;

                        case 9:
                            Console.WriteLine("\nAgregar a Carrito\n______________________________________");

                            Console.Write("Ingrese ID del Producto: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Ingrese Cantidad de Producto: ");
                            cantidad = Convert.ToInt32(Console.ReadLine());
                            Carrito.CreateCarrito(id, cantidad);

                            WaitInput();
                            break;

                        case 10:
                            Console.WriteLine("\nEliminar del Carrito\n______________________________________");

                            Console.Write("Ingrese ID del Producto a Eliminar: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            Carrito.DeleteCarrito(id);

                            WaitInput();
                            break;

                        case 11:
                            Console.WriteLine("\nMostrar Carrito\n______________________________________");
                            Carrito.ReadCarrito();

                            WaitInput();
                            break;


                        case 12:
                            Console.WriteLine("\nGenerar Boleta\n______________________________________");

                            Console.WriteLine(Carrito.CalcTotal());

                            WaitInput();
                            break;

                        case 13:
                            Console.WriteLine("\nPagar Boleta\n______________________________________");
                            Console.WriteLine("Tipo de Pago? [1: Efectivo | 2: Debito | 3: Credito]");
                            int pago = Convert.ToInt32(Console.ReadLine());

                            Boleta.CreatePagoAsync(pago);

                            WaitInput();
                            break;

                        case 14:
                            Console.WriteLine("\nPagar Boleta\n______________________________________");

                            Console.WriteLine(Carrito.CalcTotal());

                            WaitInput();
                            break;

                        case 15:
                            Console.WriteLine("Salir");
                            o = true;
                            break;

                        default:
                            Console.WriteLine("Intentelo nuevamente");
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }            
        
        public static void WaitInput()
        {
            Console.Write("'Enter' para desplegar el Menu... ");
            Console.ReadLine();
            Console.Clear();
        }
    }
}