using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int suma = 0;

            int contador = 0;

            do
            {
                if (contador % 2 == 0)
                {
                    suma += contador;
                    contador++;
                    Console.WriteLine("El número es: " + contador);
                }
                else
                {

                    // Sin esto se queda en bucle en 1, ya que 1 no cumple la condición del if y no se suma 1 al contador
                    contador++;
                    Console.WriteLine("El número es: " + contador);
              
                }
            } while (contador < 50);




            Console.WriteLine(suma);
        }
    }
}
