using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Declaraciones_IF
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool registrado = false;
            bool registrar = true;
            string username = "";
            string password = "";

            Console.Write("¿Está registrado? (S/N): ");
            string respuesta = Console.ReadLine().ToUpper();

            if (respuesta == "S")
            {
                Console.Write("Ingrese su nombre de usuario: ");
                username = Console.ReadLine();
                Console.Write("Ingrese su contraseña: ");
                password = Console.ReadLine();
                registrado = true;
            } else
            {
                Console.Write("Introduzca un nombre de usuario: ");
                username = Console.ReadLine();
                Console.Write("Introduzca una contraseña: ");
                password = Console.ReadLine();
                registrado = true;
            }

            if (registrado)
            {
                Console.WriteLine("Usuario registrado correctamente.");
                Console.WriteLine($"Nombre de usuario: {username}");
                Console.WriteLine($"Contraseña: {password}");
            }
            else
            {
                Console.WriteLine("No se pudo registrar al usuario.");
            }
        }
    }
}
