using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_Propiedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Automovil automovil = new Automovil();
            automovil.marca = "Toyota";
            automovil.modelo = "Corolla";
            automovil.identificacion = "ABC123";
            automovil.Anio = 2020; // Asignar un año válido
            automovil.MostrarInformacion();

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
