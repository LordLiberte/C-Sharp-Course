using System;


namespace Tipos_Datos_IntFloatDouble
{
    internal class Program
    {


        static void Main(string[] args)
        {
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
            string mensaje = "Hola, mi nombre es ";
            Console.WriteLine(mensaje + MiNombre);

        }
    }
}
