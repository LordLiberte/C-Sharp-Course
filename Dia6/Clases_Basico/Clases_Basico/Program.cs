using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Basico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto de la clase Humano
            // clase nombre = new Clase();
            Humano juan = new Humano();

            // Asignar un valor a la variable miembro
            juan.primerNombre = Console.ReadLine();
            juan.edad = 20; // Asignar un valor a la variable miembro edad
            juan.edadHumano(); // Llamar al método edadHumano
            juan.ComprobarEdad(); // Llamar al método ComprobarEdad
            juan.apellido = "Pérez"; // Asignar un valor a la variable miembro apellido
            juan.presentarse(); // Llamar al método presentarse

            // Crear otro objeto de la clase Humano
            Humano maria = new Humano();
            maria.primerNombre = "María";
            maria.presentarse();
        }
    }
}
