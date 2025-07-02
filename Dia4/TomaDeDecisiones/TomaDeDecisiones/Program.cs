using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaDeDecisiones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese la temperatura: ");
            int temperatura = int.Parse(Console.ReadLine());

            if (temperatura < 22)
            {
                Console.WriteLine("Hace frio, abrigate");
            }
            else if (temperatura == 22)
            {
                Console.WriteLine("Se está fresco");
            }
            else
            {
                Console.WriteLine("Hace calor, puedes ir ligero de ropa.");
            }
        }            
    }
}
