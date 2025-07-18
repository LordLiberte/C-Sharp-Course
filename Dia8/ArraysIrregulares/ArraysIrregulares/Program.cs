using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysIrregulares
{

    // Los arrays normales tienen la misma longitud y anchura en todas sus dimensiones.
    // Los arrays irregulares pueden tener diferentes longitudes en cada fila.

    internal class Program
    {
        static void Main(string[] args)
        {
            // Ponemos dos pares de llaves para indicar que es un array irregular. Esto significa que tiene arrays dentro de arrays
            int[][] arrayIrregular1 = new int[3][]; // Arrays dentro del array principal => 3 arrays 

            arrayIrregular1[0] = new int[5]; // El primer array tiene 5 elementos
            arrayIrregular1[1] = new int[3]; // El segundo array tiene 3 elementos
            arrayIrregular1[2] = new int[2]; // El tercer array tiene 2 elementos

            // Asignamos valores a los elementos del array irregular

            arrayIrregular1[0] = new int[] { 1, 2, 3, 4, 5 }; // Asignamos valores al primer array
            arrayIrregular1[1] = new int[] { 6, 7, 8 }; // Asignamos valores al segundo array
            arrayIrregular1[2] = new int[] { 9, 10 }; // Asignamos valores al tercer array

            // Segunda forma de crear un array irregular

            int[][] arrayIrregular2 = new int[3][]
            {
                new int[] { 1, 2, 3, 4, 5 }, // Primer array con 5 elementos
                new int[] { 6, 7, 8 },       // Segundo array con 3 elementos
                new int[] { 9, 10 }          // Tercer array con 2 elementos
            };

            // Imprimimos algun valor de array

            Console.WriteLine(arrayIrregular1[2][0]);

            int[][] arrayIrregular = new int[][]
            {
                new int[] { 0, 2, 4},
                new int[] { 1, 3, 5, 7, 9},
                new int[] { 6, 8, 10},
                new int[] { 20, 30, 40, 50}
            };

            for (int i = 0; i < arrayIrregular[2].Length; i++)
            {
                Console.WriteLine(arrayIrregular[2][i]);
            }

        }
    }
}
