using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadorTernario_IF_mejorada
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int temperatura = 30;
            string estadoDelAgua;


            /* Lo que se haría
            if (temperatura <0)
            {
                estadoDelAgua = "Sólido";
            }
            else if (temperatura >= 0 && temperatura < 100)
            {
                estadoDelAgua = "Líquido";
            }
            else
            {
                estadoDelAgua = "Gaseoso";
            }

            */

            // If mejorado variable = condición ? valorSiVerdadero : valorSiFalso;

            estadoDelAgua = (temperatura < 0) ? "Sólido" :
                            (temperatura >= 0 && temperatura < 100) ? "Líquido" :
                            "Gaseoso";

            Console.WriteLine($"El estado del agua a {temperatura}°C es: {estadoDelAgua}");

            int resultadoExamen = 8;

            string mensaje;

            mensaje = (resultadoExamen < 4) ? "Aplazado" :
                      (4 < resultadoExamen && resultadoExamen < 7) ? "Aprobado" :
                      "Promocionado";

            Console.WriteLine(mensaje);


        }
    }
}
