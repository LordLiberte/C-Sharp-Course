using System;


namespace Desafio_Propiedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos una instancia de la clase Caja
            Caja caja = new Caja();

            // Las propiedades publicas se asignan de forma explicita
            caja.Largo = 20;
            caja.Ancho = 5;

            // Mostramos por pantalla el valor de las propiedades de la caja
            Console.WriteLine(caja.Largo);
            Console.WriteLine(caja.Ancho);

            // Mostramos por pantalla el valor de la propiedad SuperficieFrontal, que es llamada dentro de la función MostrarInfo,
            // y que calcula la superficie frontal de la caja directamente desde las propiedades Largo y Ancho.
            Console.WriteLine(caja.MostrarInfo()); 

        }
    }
}
