using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaDeDecisiones_TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numTemperatura;
            string temperatura = Console.ReadLine();
            
            if (int.TryParse(temperatura, out int numero))
            {
                numTemperatura = numero;

                if (numTemperatura < 0)
                {
                    Console.WriteLine("Hace frío");
                }
                else if (numTemperatura >= 0 && numTemperatura <= 20)
                {
                    Console.WriteLine("Hace fresco");
                }
                else if (numTemperatura > 20 && numTemperatura <= 27)
                {
                    Console.WriteLine("Hace calor");
                }
                else
                {
                    Console.WriteLine("Hace mucho calor");
                }
            }
            else
            {
                numTemperatura = 0; // Valor por defecto si la conversión falla
                Console.WriteLine("El valor ingresado no es válido. Por favor, ingrese un número entero.");
            }
        }

    }
}
