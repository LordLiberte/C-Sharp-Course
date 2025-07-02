using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1 = 5;
            int num2 = 3;
            int num3;

            // Operadores Unarios
            num3 = -num1; // Negación
            Console.WriteLine($"Negación de {num1}: {num3}");


            bool haySol = true;
            Console.WriteLine($"¿Hay sol? {!haySol}"); // ! es la negación lógica

            // Operadores de adición
            int num = 0;
            num++;  // Suma 1 al numero
            Console.WriteLine(num);

            // Operadores de sustracción
            num--; // Resta 1 al numero
            Console.WriteLine(num);




        }
    }
}
