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

            int numero = 5;
            int factorial = 1;

            /* 
             * 
             * Lo que hace este bucle es determinar el counter como 1, lo compara al numero para hacer el factorial, si es menor o igual
             * entonces entra al bucle y multiplica el valor factorial actual por el numero de contador (en el primer caso es 1) entonces
             * 1x1 es 1, incrementa ahora el counter a 2, haciendo que el factorial ahora sea 1x2, entonces factorial vale 2. 
             * El contador pasa a valer 3, entonces es 2x3 y factorial pasa a valer 6. El contador pasa a 4 y el factorial pasa a 4x6. 
             * El contador pasa a 5 y entonces pasa a 24x5
             * 
             */

            for (int counter = 1; counter <= numero; counter++)
            {

                factorial = (factorial * counter);
            }



            Console.WriteLine(factorial);
        }
    }
}
