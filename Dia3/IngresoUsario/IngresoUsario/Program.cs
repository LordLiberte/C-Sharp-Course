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

            Console.WriteLine("¡Bienvenido a la calculadora!");
            Console.WriteLine("Solo sirvo para sumar, así que no pidas mucho");
            Console.Write("Ingrese el primer número: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            int resultado = num + num2;
            Console.WriteLine($"El resultado de la suma es: {resultado}");


        }
    }
}
