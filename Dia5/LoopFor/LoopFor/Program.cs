using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopFor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int contador = 0; contador < 100; contador++)
            {
                Console.WriteLine("Contador: " + contador);
                Console.ReadLine();
            }
        }
    }
}
