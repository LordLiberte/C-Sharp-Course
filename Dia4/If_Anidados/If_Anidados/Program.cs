using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Anidados
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool esAdmin = false;
            bool estaRegistrado = true;
            string username = "";

            Console.Write("Por favor, ingrese su nombre de usuario: ");
            username = Console.ReadLine();

            if (estaRegistrado)
            {
                Console.WriteLine("Hola, usuario registrado.");
                if (username != "")
                {
                    Console.WriteLine($"Hola, {username}.");
                    if (username.Equals("admin"))  // Equals method for string comparison
                    {
                        Console.WriteLine("Bienvenido, administrador.");
                    }
                }
            }

            Console.Read();

        }
    }
}
