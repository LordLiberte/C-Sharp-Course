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

        // Constructor por defecto. Se ejecuta al crear una instancia de la clase Humano.
        // Con esto se crea un constructor por defecto. A la instancia habrá que asignarle valores en el programa principal.
        public Humano(string nombre, string apellido, int edad, string colorOjos)
        {
            this.nombre = nombre;  // Con this se hace referencia a los atributos de la clase a la que asignamos valores de los parámetros del constructor.
            this.apellido = apellido;
            this.edad = edad;
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
        public void Saludar()
        {
            Console.WriteLine("Hola " + nombre + " " + apellido);
        }
    }
}
