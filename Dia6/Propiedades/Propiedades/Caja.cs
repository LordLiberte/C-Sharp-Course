using System;

// Espacio para crear clases y miembros
namespace Propiedades
{
    internal class Caja
    {
        // Miembros variables
        private int largo;
        private int alto;
        // private int ancho; Al usar la forma abreviada de definir propiedades no es necesario declarar la variable ancho aquí
        private int volumen;  // Con esto ya no se puede modificar el volumen directamente
                              // desde fuera de la clase, lo que es una buena práctica de encapsulamiento. Se calcula automatico 
                              // al llamar al método MuestraInfo.


        // Esta forma agrupa getters y setters en una sola propiedad
        // Forma larga de definir propiedades
        public int Largo
        {
            get
            {
                return largo;
            }
            set
            {
                if (value < 0) value = -value; // Asegura que el largo no sea negativo
                largo = value;
            }
        }

        public int Volumen
        {
            get
            {
                return Ancho*alto*largo;
            }
            private set // El setter es privado para evitar que se modifique directamente desde fuera de la clase
            {
                volumen = value;
            }
        }

        // Forma abreviada de definir propiedades
        public int Ancho { get; set; }

        // El encapsulamiento de las propiedades permite controlar el acceso a los miembros
        // y proporciona una forma de validar los datos antes de asignarlos.

        // Miembro método
        public void MuestraInfo()
        {
            Console.WriteLine("Largo: " + largo); 
            Console.WriteLine("Alto: " + alto); 
            Console.WriteLine("Ancho: " + Ancho); // Accede al getter de Ancho, que es una propiedad abreviada
            Console.WriteLine("Volumen: " + Volumen); // Accede al getter de Volumen, que calcula el volumen automáticamente
        }

        // Setter para la propiedad largo
        public void SetLargo(int largo)
        {
            this.largo = largo;
        }

        /*public void SetAncho(int ancho)
        {
            this.ancho = ancho;
        }*/

        public void SetAlto(int alto)
        {
            this.alto = alto;
        }
    }
}
