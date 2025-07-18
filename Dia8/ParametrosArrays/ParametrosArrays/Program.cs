using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametrosArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] puntajes = new int[5];
            // Llenar el array con puntajes
            for (int i = 0; i < puntajes.Length; i++)
            {
                Console.Write($"Ingrese el puntaje {i + 1}: ");
                puntajes[i] = int.Parse(Console.ReadLine());

                // Validar que el puntaje esté entre 0 y 100
                if (puntajes[i] < 0 || puntajes[i] > 100)
                {
                    Console.WriteLine("El puntaje debe estar entre 0 y 100. Intente de nuevo.");
                    i--; // Decrementar i para repetir la entrada
                }
            }
            // Calcular el promedio
            double promedio = ObtenerPromedio(puntajes);
            // Mostrar el promedio
            Console.WriteLine($"El promedio de los puntajes es: {promedio}");
        }

        static double ObtenerPromedio(int[] arrayPuntajes)
        {
            int cantidad = arrayPuntajes.Length;
            if (cantidad == 0)
            {
                return 0; // Evitar división por cero
            }

            int suma = 0;

            for (int i = 0; i<cantidad; i++)
            {
                suma += arrayPuntajes[i];
            }

            double media = (double)suma / cantidad;
            return media;
        }
    }
}
