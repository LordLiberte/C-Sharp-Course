using System;
using System.Collections; // Necesario para usar ArrayList
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists
{

    // Los array lists son una coleccion de objetos que pueden crecer y decrecer de tamaño dinamicamente
    // Son una coleccion de objetos que pueden ser de cualquier tipo
    // Se pueden agregar, eliminar y acceder a los elementos de la coleccion
    // Se pueden ordenar, buscar y filtrar los elementos de la coleccion

    internal class Program
    {
        static void Main(string[] args)
        {

            // Declaración de un ArrayList
            ArrayList miArrayList = new ArrayList(); // Indeterminado

            ArrayList miArrayList2 = new ArrayList(100); // Determinado

            // Agregar elementos al ArrayList
            miArrayList.Add("Hola");
            miArrayList.Add(123);
            miArrayList.Add(45.67);
            Console.WriteLine("Elementos en el ArrayList: " + miArrayList.Count);

            // Acceder a los elementos del ArrayList2
            miArrayList2.Add("Hola");
            miArrayList2.Add(123);
            miArrayList2.Add(10020002);
            miArrayList2.Add(45.67);
            miArrayList2.Add("Mundo");
            miArrayList2.Add("Hola");
            Console.WriteLine("Elementos en el ArrayList2: " + miArrayList2.Count);


            // Eliminar un elemento del ArrayList
            miArrayList.Remove("Hola");
            Console.WriteLine("Elementos en el ArrayList después de eliminar 'Hola': " + miArrayList.Count);
            // Eliminar un elemento del ArrayList2
            miArrayList2.Remove(123);
            // Eliminar un elemento del ArrayList2
            miArrayList2.RemoveAt(1);
            Console.WriteLine("Elementos en el ArrayList2 después de eliminar un 45.67: " + miArrayList2.Count);

            // Acceder a un elemento del ArrayList
            Console.WriteLine("Primer elemento del ArrayList: " + miArrayList[0]);
            miArrayList.Reverse();
            Console.WriteLine("Primer elemento del ArrayList después de revertir: " + miArrayList[0]);

            // Acceder a un elemento del ArrayList2
            Console.WriteLine("Primer elemento del ArrayList2: " + miArrayList2[0]);
            miArrayList2.Reverse();
            Console.WriteLine("Primer elemento del ArrayList2 después de revertir: " + miArrayList2[0]);


            // Recorrer cada valor del ArrayList
            foreach (object obj in miArrayList)
            {
                Console.WriteLine("Valor del ArrayList: " + obj);
                foreach (object obj2 in miArrayList2)
                {
                    Console.WriteLine("Valor del ArrayList2: " + obj2);
                }   
            }

            ArrayList miArrayList23 = new ArrayList();

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    miArrayList23.Add(i);
                    Console.WriteLine("Valor del ArrayList23: " + i);
                }
            }

            foreach (int number in miArrayList23)
            {
                Console.WriteLine("Número par del ArrayList23: " + number);
                Console.WriteLine(miArrayList23.Count);
            }

            List<int> miLista = new List<int> { 2,1,5,3,4 };

            miLista.Sort(); // Ordena la lista
            foreach (int numero in miLista)
            {
                Console.WriteLine("Número de la lista: " + numero);
            }
            miLista.IndexOf(3); // Devuelve el índice del elemento 3 en la lista


        }
    }
}
