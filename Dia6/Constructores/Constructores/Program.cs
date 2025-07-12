using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Humano human = new Humano(nombre: Console.ReadLine(), apellido: Console.ReadLine());
            human.Saludar();
        }
    }
}
