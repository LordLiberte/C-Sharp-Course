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
            /*
            // Crear una instancia de la clase Humano utilizando el constructor definido en la clase Humano.
            Humano human = new Humano
                (
                nombre: Console.ReadLine(), 
                apellido: Console.ReadLine(), 
                edad: int.Parse(Console.ReadLine()), 
                colorOjos: "Azules"
                );

            // Llamar al método Saludar de la instancia creada.
            human.Saludar();
            */

            // Crear una instancia de la clase Humano utilizando el constructor por defecto.
            Humano human = new Humano("Alberto", "Pérez", "Marrón");
            human.Saludar();
        }
    }
}
