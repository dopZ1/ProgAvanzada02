using System;
using System.Collections.Generic;
using System.Text;

namespace ProgAvanzada02
{
    class Usuario
    {
        protected static List<Usuario> usuarios = new List<Usuario>();
        int id { get; set; }
        string nombre { get; set; }
        string apellido { get; set; }
        int rut { get; set; }
        string direccion { get; set; }
        byte tipo { get; set; }

        public Usuario(int id, string nombre, string apellido, int rut, string direccion, byte tipo)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.rut = rut;
            this.direccion = direccion;
            this.tipo = tipo;
        }

        public static void CreateUser(int id, string nombre, string apellido, int rut, string direccion, byte tipo)
        {
            if (!VerificarId(id))
            {
                usuarios.Add(new Usuario(id, nombre, apellido, rut, direccion, tipo));
                Console.WriteLine("Cliente Creado!\n");
            } 
            else
            {
                Console.WriteLine("Cliente ya existe!\n");
            }

        }

        public static void UpdateUser(int id, string nombre, string apellido, int rut, string direccion, byte tipo)
        {
                if (NotNull())
                {
                    foreach (var u in usuarios)
                    {
                        if (id.Equals(u.id))
                        {
                            Console.Write($"Nombre: {u.nombre}\nApellido: {u.apellido}\nRut: {u.rut}\nDireccion: {u.direccion}\nTipo: {u.tipo}\n");
                            u.nombre = nombre;
                            u.apellido = apellido;
                            u.rut = rut;
                            u.direccion = direccion;
                            u.tipo = tipo;
                        }
                        else
                        {
                            Console.WriteLine("Cliente no Encontrado\n");
                        }
                    }
                    Console.WriteLine("Cliente Modificado!\n");
                }
        }

        public static void DeleteUser(int id)
        {
            if (NotNull())
            {
                if (VerificarId(id))
                {
                    foreach (var u in usuarios)
                    {
                        if (id.Equals(u.id))
                        {
                            usuarios.Remove(u);
                            Console.WriteLine("Cliente Eliminado!\n");
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Cliente No Existe!\n");
                }
            }
        }

        public static void ReadUsers()
        {
            foreach (var u in usuarios)
            {
                Console.WriteLine($"ID: {u.id}\nNombre: {u.nombre}\nApellido: {u.apellido}\nRut: {u.rut}\nDireccion: {u.direccion}\nTipo: {u.tipo}\n");
            }
        }

        private static bool NotNull()
        {
            if (usuarios.Count > 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("\nIngrese un Cliente Primero\n");
                return false;
            }
        }

        private static bool VerificarId(int id)
        {
            foreach (var c in usuarios)
            {
                if (id.Equals(c.id))
                {
                    return true;
                }
            }
            return false;
        }
    }
}