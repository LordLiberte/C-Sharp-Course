using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_If_Mejorado
{

    /*
     
      Si el valor ingresado no es un integer, debe imprimir en la consola "Esa no es una temperatura válida".

      En caso de que el valor ingresado sí sea un integer válido, entonces debe hacer lo siguiente:

      Si el valor de la temperatura ingresada es <=15 debe escribir "Hace mucho frio" en la consola.

      Si el valor de la temperatura ingresada es entre >= 16 y <=28 debe escribir "Hace un clima agradable" en la consola.

      Si el valor de la temperatura ingresada es > 28 debe escribir "Hace mucho calor" en la consola.
    
     */


    internal class Program
    {
        static void Main(string[] args)
        {

            string temperaturaIngresada;
            Console.Write("Ingrese una temperatura en grados Celsius:");
            temperaturaIngresada = Console.ReadLine();

            bool esInteger = int.TryParse(temperaturaIngresada, out int temperatura);

            string mensaje;

            if (esInteger)
            {
                mensaje = (temperatura <= 15) ? "Hace mucho frio" :
                          (temperatura >= 16 && temperatura <= 28) ? "Hace un clima agradable" :
                          "Hace mucho calor";

                Console.WriteLine(mensaje);

            }


        }
    }
}
