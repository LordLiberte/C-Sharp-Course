using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {

        /*
         * Los arrays almacenan una cantidad fija de elementos, los elementos deben ser del mismo tipo de dato, pero puede
         * contener cualquier tipo de dato mientras todo sea del mismo tipo.
         * Es ideal para almacenar una colección de datos
         * El indice de cada elemento de un array comienza en 0, por lo que el primer elemento se encuentra en la posicion 0
         * Así un array de 5 elementos tiene los indices del 0 al 4 => 0, 1, 2, 3, 4
         */

        // DECLARACIÓN DE UN ARRAY
        // tipoDeDato[] nombreArray = new tipo de dato[tamaño del array]; 

        static void Main(string[] args)
        {
            int[] arraynumeros = new int[5]; // Declaración de un array de enteros con 5 elementos
            // Asignación de valores a los elementos del array
            arraynumeros[0] = 1;
            arraynumeros[1] = 2;
            arraynumeros[2] = 3;
            arraynumeros[3] = 4;
            arraynumeros[4] = 5;

            // Imprimir los valores del array
            Console.WriteLine("Elementos del array:");
            Console.WriteLine("Primero: " + arraynumeros[0]); // Imprime el primer elemento
            Console.WriteLine("Segundo: " + arraynumeros[1]); // Imprime el segundo elemento
            Console.WriteLine("Tercero: " + arraynumeros[2]); // Imprime el tercer elemento
            Console.WriteLine("Cuarto: " + arraynumeros[3]); // Imprime el cuarto elemento
            Console.WriteLine("Quinto: " + arraynumeros[4]); // Imprime el quinto elemento

        }
    }
}
