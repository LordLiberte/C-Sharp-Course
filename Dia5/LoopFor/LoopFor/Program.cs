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

            int suma = 0;

            for (int contador = 0; contador < 50; contador++)
            {
                if (contador % 2 == 0)
                {
                    suma += contador;
                }
            }



            Console.WriteLine(suma);
        }
    }
}
