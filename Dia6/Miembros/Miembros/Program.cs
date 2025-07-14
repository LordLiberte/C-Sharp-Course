using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miembros
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Miembros newMiembro = new Miembros("Carlos Gonzalez", "Ingeniero de IA", 130000, "CHF", 28, 23920019);
            // Acceso a miembros públicos
            newMiembro.Amigo(true);


        }
    }
}
