using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakandContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Desafio - Loop Promedio

            string terminar = "";
            float media = 0;
            float nota = 0;
            float notas = 0;
            int contador = 1;

            Console.WriteLine("Ingrese notas para calcular el promedio. Escriba 'fin' para terminar.");
            Console.Write("");

            while (terminar != "fin")
            {
                Console.WriteLine("Ingrese 'fin' para terminar o pulse enter para continuar");
                terminar = Console.ReadLine();

                if (terminar == "fin" && contador == 1)
                {
                    Console.WriteLine("No se ingresaron notas.");
                    continue;
                }
                if (terminar == "fin")
                {
                    Console.WriteLine($"El promedio de las notas es: {media}");
                    break;
                }
                else
                {
                    Console.Write("Ingrese una nota: ");
                    nota = float.Parse(Console.ReadLine());
                    notas += nota;
                    media = notas / (contador);
                    contador++;
                }
            }


           
        }
    }
}
