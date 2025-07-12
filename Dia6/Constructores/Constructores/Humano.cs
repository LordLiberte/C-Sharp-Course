using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    internal class Humano
    {
        private string nombre;
        private string apellido;
        private int edad;
        private string colorOjos;

        // Se ejecuta al crear una instancia de la clase Humano.
        // Con esto se crea un constructor por defecto. A la instancia habrá que asignarle valores en el programa principal.
        // Constructor de tipo parametrizado
       
        public Humano(string nombre, string apellido, string colorOjos)
        {
            this.nombre = nombre;  // Con this se hace referencia a los atributos de la clase a la que asignamos valores de los parámetros del constructor.
            this.apellido = apellido;
            this.colorOjos = colorOjos;
        }

        /*
        public void PrimerNombre()
        {
            nombre = Console.ReadLine();
        }

        public void PrimerApellido()
        {
             apellido = Console.ReadLine();
        }
        */

        // Constructor por defecto. Constructor no parametrizado.
        public Humano()
        {
            Console.WriteLine("Constructor por defecto. Objeto Creado");
        }

        // Método para saludar al humano.
        public void Saludar()
        {
            Console.WriteLine("Hola " + nombre + " " + apellido);
        }
    }
}
