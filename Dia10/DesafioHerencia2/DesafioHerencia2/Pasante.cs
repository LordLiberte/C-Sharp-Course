using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioHerencia2
{
    internal class Pasante: Empleado
    {

        // Atributos del pasante
        protected int HorasDeTrabajo;
        protected int HorasDeEscuela;

        // Constructor parametrizado de pasante que hereda los parametros de la clase base Empleado
        public Pasante(string Nombre, string Apellido, int Salario, int HorasDeTrabajo, int HorasDeEscuela) : base(Nombre, Apellido, Salario)
        {
            this.HorasDeTrabajo = HorasDeTrabajo;
            this.HorasDeEscuela = HorasDeEscuela;
        }

        public void Aprender()
        {
            Console.WriteLine($"Estoy aprendiendo durante {HorasDeEscuela} horas");
        }

        // Sobreescribimos el método Trabajar de la clase base Empleado
        public override void Trabajar()
        {
            Console.WriteLine($"Estoy trabajando durante {HorasDeTrabajo} horas");

        }
    }
}
