using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Basico
{
    class Humano
    {
        // Miembro Variable
        public string primerNombre;
        public int edad;
        public string apellido;


        // Miembro método

        public void presentarse()
        {

            comprobarNombre(primerNombre + " " + apellido);

        }

        public void edadHumano()
        {
            Console.WriteLine("Tengo " + edad + " años.");
        }


        public void ComprobarEdad()
        {
            if (edad < 18)
            {
                Console.WriteLine("Eres menor de edad.");
            }
            else
            {
                Console.WriteLine("Eres mayor de edad.");
            }
        }

        public void comprobarNombre(string nombre)
        {
            if (nombre == null || nombre == "")
            {
                Console.WriteLine("No tienes nombre.");
            }
            else
            {
                Console.WriteLine("Tu nombre es " + nombre);
            }
        }



    }
}
