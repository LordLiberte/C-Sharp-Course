using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParseMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* El método TryParse se usa para determinar si se puede parsear un string al tipo de dato que queremos. En caso afirmativo, la variable
             booleana se pone en True y se carga el valor parseado en otra variable (por ejemplo integer). En caso de que no se pueda exito es false
            y no se carga el valor */

            string input = Console.ReadLine();
            int numberParsed;

            bool isParsed = int.TryParse(input, out numberParsed);

            Console.WriteLine($"Input: {input}");
            Console.WriteLine($"Is Parsed: {isParsed}");
            if (isParsed)
            {
                Console.WriteLine($"Parsed Number: {numberParsed} como {numberParsed.GetType()}");
            }
            else
            {
                Console.WriteLine("Failed to parse the input.");
            }
        }
    }
}
