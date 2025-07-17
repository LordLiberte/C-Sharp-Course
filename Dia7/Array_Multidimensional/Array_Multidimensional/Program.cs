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
            // Declaración de un array multidimensional --> 2 dimensiones en este caso
            string[,] matriz2D;

            // Declaración de un array multidimensional --> 3 dimensiones en este caso
            int[,,] matriz3D;


            /* Codigo ejemplo para un array bidimensional
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
            */

            // ARRAY 3D
            // Inicialización de un array tridimensional con 3 matrices bidimensionales de 3x3
            string[,,] array3D = new string[,,]
            {
                {
                    {"A1", "B1", "C1"},
                    {"D1", "E1", "F1"},
                    {"G1", "H1", "I1"}
                },
                {
                    {"A2", "B2", "C2"},
                    {"D2", "E2", "F2"},
                    {"G2", "H2", "I2"}
                },
                {
                    {"A3", "B3", "C3"},
                    {"D3", "E3", "F3"},
                    {"G3", "H3", "I3"}
                }
            };

            Console.WriteLine("Array 3D:");
            for (int i = 0; i < array3D.GetLength(0); i++)
            {
                for (int j = 0; j < array3D.GetLength(1); j++)
                {
                    for (int k = 0; k < array3D.GetLength(2); k++)
                    {
                        Console.Write(array3D[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.Write("Que valor desea buscar en la matriz 3D: ");
            string deseado3D = Console.ReadLine();
            bool encontrado = false;
            foreach (string item in array3D)
            {
                if (item == deseado3D)
                {
                    Console.WriteLine($"Se encontró el elemento {deseado3D} en la matriz 3D.");
                    encontrado = true;
                    continue; // Salimos del bucle si encontramos el elemento
                }
                else
                {
                    Console.WriteLine("No coincidente");
                    continue; // Continuamos buscando en el resto de la matriz
                }
            }

            // Para hacer referencia al elemento de un array tridimensional, primero especificamos a cual de los arrays bidimensionales
            // accedemos y luego a la coordenada del elemento dentro de ese array bidimensional.
            Console.WriteLine(array3D[1,2,2]); // Accede al elemento en la segunda matriz, tercera fila, cuarta columna


        }
    }
}
