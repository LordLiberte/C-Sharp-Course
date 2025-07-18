using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_95_Irregulares
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[][] persona = new string[3][]
            {
                new string[2] { "Arturo", "Carlos" },
                new string[4] { "Angela", "Juan", "Juan", "Celia" },
                new string[3] { "Ingrid", "Belén", "Abuela" }

            };

            foreach (string person in persona[0])
            {
                foreach(string name in persona[1])
                {
                    Console.WriteLine($"Hola {person} te presento a {name}");
                }

                foreach (string name in persona[2])
                {
                    Console.WriteLine($"Hola {person} te presento a {name}");
                }
            }

        }
    }
}
