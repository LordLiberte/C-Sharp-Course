using System;


namespace Tipos_Datos_IntFloatDouble
{
    class ClientControl  // La primera letra de la clase debe ser mayúscula, por convención. Llamado Pascal Case
    {

        static void Main(string[] args) // se prefieren verbos para los nombres de los métodos, por convención.
        {

            int ctrlStock = 30; // Formato Camel Case, la primera letra de cada palabra es mayúscula, excepto la primera palabra

            Console.WriteLine("El Stock disponible es: " + ctrlStock); // Imprimir en consola


            // Cambiar el color de la consola y las letras
            Console.ForegroundColor = ConsoleColor.DarkRed; // Letras
            Console.BackgroundColor = ConsoleColor.DarkGreen; // Fondo
            Console.Clear(); // Limpiar la consola para aplicar los cambios de color

            // Numeros enteros -- integer numbers (int)
            int num1 = 13;
            int num2 = 7;
            int suma = num1 + num2;
            Console.WriteLine("La suma de " + num1 + " más " + num2 + " como números enteros da como resultado " + suma);


            // Numeros de punto flante -- floating point numbers (float)
            float num3 = 13.5f;
            float num4 = 7.4f;
            float sumaFloat = num3 + num4;
            Console.WriteLine(sumaFloat);

            // Numeros de punto flante de doble precision -- double precision floating point numbers (double)
            double num5 = 13.544;
            double num6 = 7.348;
            double sumaDouble = num5 + num6;
            Console.WriteLine(sumaDouble);

            // Cadena de texto -- string
            string MiNombre = "Carlos";
            MiNombre = MiNombre.Replace("a", "2");
            string mensaje = "Hola, mi nombre es " + MiNombre;

            // Existen métodos para los tipos de datos
            Console.WriteLine(mensaje.ToUpper());

            // Ejemplo de lectura de datos sin saltar lineas con Write
            string respuesta = "";
            Console.Write("Escriba su edad: ");
            respuesta = Console.ReadLine();
            Console.WriteLine("Su edad es {0}", respuesta); // {0} es un marcador de posición para la variable respuesta, donde se coloque, saldrá el valor de la variable asignada
            Console.ReadKey();

            // Ejemplo de uso de un método para obtener el nombre
            MiNombre = GetName("Carlos"); // Llamada al método GetName con el nombre "Carlos"
            Console.WriteLine("El nombre obtenido es: " + MiNombre); // Imprimir el nombre obtenido


            // Conversiones explicitas entre tipos de datos -- el proceso se llama Casting
            double miDouble = 3.14;
            int miEntero;
            miEntero = (int)miDouble; // Con la conversión explicita se pierden los decimales del numero original
            Console.WriteLine(miEntero);

            // Conversiones implicitas entre tipos de datos -- el proceso se llama Implicit Casting
            int Num = 123456;
            long miLong; // Long es un tipo de dato que puede almacenar números enteros más grandes que int
            miLong = Num; // No es necesario el casting explícito, ya que int puede ser convertido a long sin perder información
            Console.WriteLine(miLong);

            float miFloat = 3.14f; // Float es un tipo de dato que puede almacenar números de punto flotante
            double miNuevoDouble = miFloat; // No es necesario el casting explícito, ya que float puede ser convertido a double sin perder información
            Console.WriteLine(miNuevoDouble);

            Console.Write("Antes de convertir Double a String:");
            Console.WriteLine(miDouble.GetType()); // Imprimir el tipo de dato de miDouble
            string miCadena = miDouble.ToString(); // Convertir un número double a una cadena de texto
            Console.Write("Después de convertir Double a String:");
            Console.WriteLine(miCadena.GetType()); // Imprimir la cadena de texto

            bool miBoolean = true; // Boolean es un tipo de dato que puede ser verdadero o falso
            Console.WriteLine("El valor de miBoolean es: " + miBoolean); // Imprimir el valor del booleano
            int miBooleanInt = Convert.ToInt32(miBoolean); // Convertir un booleano a un entero (1 para true, 0 para false)
            Console.WriteLine(miBooleanInt); // Imprimir el valor del entero convertido
            string miBooleanString = miBoolean.ToString(); // Convertir un booleano a una cadena de texto


        }

        public static string GetName(string name)
        {
            return name; // Método que devuelve el nombre pasado como parámetro
        }
    }
}
