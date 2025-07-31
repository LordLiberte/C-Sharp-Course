using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioHerencia2
{
    internal class Jefe: Empleado
    {

        protected string AutoDeEmpresa { get; set; }

        // Constructor parametrizado de jefe que hereda los parametros de la clase base Empleado
        public Jefe(string Nombre, string Apellido, int Salario, string AutoDeEmpresa) : base(Nombre, Apellido, Salario)
        {
            this.AutoDeEmpresa = AutoDeEmpresa;
        }

        public void Dirigir()
        {
            Console.WriteLine("Soy el jefe");
        }
    }
}
