using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Constantes
{
    internal class Program
    {

        /* Las constantes son variables que no cambian su valor durante la ejecución del programa. 
         * Se declaran en la clase, y no en un método especifico a no ser que funcione solo en esta función.*/

        const double PI = 3.14159265358979323846; // Numero Pi
        const int weeks = 52; // Semanas de un año
        const int months = 12; // Meses de un año
        const int days = 365; // Días de un año
        const string birthday = "05 de octubre de 2001"; // Fecha de cumpleaños


        static void Main(string[] args)
        {
            Console.WriteLine("Constantes en C#");
            // PI = PI + 1; Esto causará un error de compilación, ya que PI es una constante y no se puede modificar.
            Console.WriteLine($"El valor de PI es: {PI}");
            Console.WriteLine($"El número de semanas en un año es: {weeks}");
            Console.WriteLine($"El número de meses en un año es: {months}");
            Console.WriteLine($"El número de días en un año es: {days}");
            Console.WriteLine($"Mi cumpleañoses el {birthday}");
        }
    }
}
