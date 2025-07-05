using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declaracion_Switch
{
    internal class Program
    {

        // Switch es una estructura de control que permite evaluar una expresión y ejecutar diferentes bloques de código según el valor de esa expresión.
        static void Main(string[] args)
        {

            int autos = 1;

            autos = int.Parse(Console.ReadLine());


            // En función de la variable autos, se ejecutará un bloque de código diferente.
            switch (autos) 
            {
                case 1:
                    Console.WriteLine("Hay un auto");
                    break;
                case 2:
                    Console.WriteLine("Hay dos autos");
                    break;
                case 3:
                    Console.WriteLine("Hay tres autos");
                    break;
                default:
                    Console.WriteLine("No hay autos");
                    break;
            }
        }
    }
}
