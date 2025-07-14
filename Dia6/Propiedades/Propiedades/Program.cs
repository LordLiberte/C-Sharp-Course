using System;


namespace Propiedades
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Crea una instancia de la clase Caja
            Caja caja = new Caja();

            caja.Largo = -20; // Usando la propiedad setter de Largo
            Console.WriteLine("Largo de la caja: " + caja.Largo); // Usando la propiedad getter de Largo

            // Asigna valores a las propiedades de la caja
            caja.SetLargo(caja.Largo); // Usando el setter para largo
            caja.SetAlto(5); // Usando el setter para alto
            caja.Ancho = 3; // Usando el setter para ancho

            // Muestra la información de la caja
            caja.MuestraInfo();

        }
    }
}
