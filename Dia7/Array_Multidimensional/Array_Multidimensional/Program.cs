using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Multidimensional
{
    internal class Program

        /*
         * Los arrays unidimensionales son aquellos que tienen una sola dimensión, es decir, una sola fila o columna.
         * Los arrays multidimensionales, por otro lado, pueden tener múltiples dimensiones, como filas y columnas en una matriz.
         * Por ejemplo , un array bidimensional puede ser visto como una tabla con filas y columnas.
         * Y un array tridimensional puede ser visto como un cubo con filas, columnas y profundidad.
         */
    {
        static void Main(string[] args)
        {
            // Delcaración de un array multidimensional --> 2 dimensiones en este caso
            string[,] matriz2D;

            // Delcaración de un array multidimensional --> 3 dimensiones en este caso
            int[,,] matriz3D;


            // ARRAY 2D
            // Inicialización de un array multidimensional con 3 filas y 3 columnas
            string[,] array2D = new string[,]
            {
                {"A" , "B", "C"},
                {"D", "E", "F"},
                {"G", "H", "I"}
            };

            Console.WriteLine("Array 2D:");
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    Console.Write(array2D[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.Write("Que valor desea buscar en la matriz 2D: ");
            string deseado = Console.ReadLine();

            foreach (string item in array2D)
            {
                if (item == deseado)
                {
                    Console.WriteLine($"Se encontró el elemento {deseado} en la matriz 2D.");
                }
                else
                {
                    continue;
                }
            }

        }
    }
}
