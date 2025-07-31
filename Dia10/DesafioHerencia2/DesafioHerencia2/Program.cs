using System;

namespace DesafioHerencia2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancias de cada clase de empleado
            Empleado jefe = new Jefe("Juan", "Perez", 5000, "Toyota");
            Empleado pasante = new Pasante("Alberto", "García", 20, 10, 35);
            Empleado empleado = new Empleado("Ana", "Lopez", 3000);

            // Llamadas a los métodos de cada empleado
            jefe.Trabajar();
            jefe.Descansar();
            ((Jefe)jefe).Dirigir(); // Llamada al método específico de Jefe

            pasante.Trabajar();
            pasante.Descansar();
            ((Pasante)pasante).Aprender(); // Llamada al método específico de Pasante

            empleado.Trabajar();
            empleado.Descansar();

            // Nota: No se puede llamar a métodos específicos de Jefe o Pasante desde la instancia de Empleado
        }
    }
}
