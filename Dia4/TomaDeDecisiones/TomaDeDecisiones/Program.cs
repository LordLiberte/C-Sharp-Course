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
            int temperatura = 24;

            if (temperatura < 10)
            {
                Console.WriteLine("Abrigate");
            }
            else if (temperatura == 10)
            {
                Console.WriteLine("Hace 10 grados de temperatura");
            }
            else
            {
                Console.WriteLine("Hace calor, puedes ir ligero de ropa.");
            }
        }            
    }
}
