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

            Producto.AddProducto(10, "Frugele Amarillo", "Frugele sabor Platano", 50, 1000);
            Producto.AddProducto(20, "Frugele Rojo", "Frugele sabor Frambuesa", 50, 1000);
            Producto.AddProducto(30, "Frugele Naranjo", "Frugele sabor Damasco", 50, 1000);
            Producto.AddProducto(40, "Frugele Morado", "Frugele sabor Guinda", 50, 1000);
            Producto.AddProducto(50, "Frugele Verde Oscuro", "Frugele sabor Manzana", 50, 1000);
            Producto.AddProducto(50, "Frugele Verde Claro", "Frugele sabor Lima Limon", 50, 1000);

            //1 = Admin || 2 = Cliente
            Persona.AddUsuario(10, "Diego", "Pavez", 1, "Apoquindo 666", 1);
            Persona.AddUsuario(20, "Natalia", "Aguilera", 2, "Apoquindo 666", 2);

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
                        "\nExtra:" +
                        "\n______________________________________" +
                        "\n9. Calcular Total de Compra" +
                        "\n10. Salir...");

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

                            Producto.AddProducto(id, nombre, descripcion, precio, cantidad);
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

                            Producto.ModProducto(id, nombre, descripcion, precio);
                            break;

                        case 3:
                            Console.WriteLine("\nEliminar Producto\n______________________________________");
                            Console.Write("Ingrese ID del producto para Eliminar: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            Producto.DelProducto(id);
                            break;

                        case 4:
                            Console.WriteLine("\nListar Productos\n______________________________________");
                            Producto.ListProducto();
                            break;

                        case 5:
                            Console.WriteLine("\nAgregar Cliente\n______________________________________");

                            Console.Write("Ingrese ID del Cliente: ");
                            int id_cl = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Ingrese Nombre del Cliente: ");
                            string nombre_cl = Console.ReadLine().ToString();
                            Console.Write("Ingrese Descripcion del Cliente: ");
                            string apellido_cl = Console.ReadLine().ToString();
                            Console.Write("Ingrese RUT del Cliente: ");
                            int rut_cl = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Ingrese Direccion del Cliente: ");
                            string direccion_cl = Console.ReadLine().ToString();
                            Console.Write("Ingrese Tipo de Cliente: ");
                            byte tipo_cl = Convert.ToByte(Console.ReadLine());

                            Persona.AddUsuario(id_cl, nombre_cl, apellido_cl, rut_cl, direccion_cl, tipo_cl);
                            break;

                        case 6:
                            Console.WriteLine("\nModificar Cliente\n______________________________________");

                            Console.Write("Ingrese ID del Cliente: ");
                            id_cl = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Ingrese Nombre del Cliente: ");
                            nombre_cl = Console.ReadLine().ToString();
                            Console.Write("Ingrese Apellido del Cliente: ");
                            apellido_cl = Console.ReadLine().ToString();
                            Console.Write("Ingrese RUT del Cliente: ");
                            rut_cl = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Ingrese Direccion del Cliente: ");
                            direccion_cl = Console.ReadLine().ToString();
                            Console.Write("Ingrese Tipo de Cliente: ");
                            tipo_cl = Convert.ToByte(Console.ReadLine());

                            Persona.ModUsuario(id_cl, nombre_cl, apellido_cl, rut_cl, direccion_cl, tipo_cl);
                            break;

                        case 7:
                            Console.WriteLine("\nEliminar Usuario\n______________________________________");
                            Console.Write("Ingrese RUT del Usuario para Eliminar: ");
                            rut_cl = Convert.ToInt32(Console.ReadLine());
                            Persona.DelUsuario(rut_cl);
                            break;

                        case 8:
                            Console.WriteLine("\nListar Usuarios\n______________________________________");
                            Persona.ListUsuario();
                            break;

                        case 9:
                            Console.WriteLine("\nCalcular Total\n______________________________________");
                            Console.Write("Ingrese ID del Producto: ");
                            int id_p = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Ingrese Cantidad deseada: ");
                            int can_p = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine($"Total: {Producto.CalcTotal(id_p, can_p)}");
                            break;

                        case 10:
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
    }
}