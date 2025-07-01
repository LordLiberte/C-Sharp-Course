using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngresoUsario
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine($"Hola, {nombre}!");

        }
    }
}
