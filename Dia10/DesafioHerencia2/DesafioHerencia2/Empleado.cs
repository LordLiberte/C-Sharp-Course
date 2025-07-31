using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioHerencia2
{
    internal class Empleado
    {

        // Atributos del empleado
        protected string Nombre { get; set; }
        protected string Apellido { get; set; }
        protected int Salario { get; set; }

        public Empleado(string Nombre, string Apellido, int Salario)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Salario = Salario;
        }

        // Cambiar 'override' por 'virtual' para permitir que las clases derivadas lo sobreescriban
        public virtual void Trabajar() => Console.WriteLine("Estoy trabajando");

        public void Descansar()
        {
            Console.WriteLine("Estoy descansando");
        }
    }
}
