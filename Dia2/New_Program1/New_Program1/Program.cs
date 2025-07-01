using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;



/*

El parsing se usa para tranformar variables de tipo string a variable numerica tipo int, float, etc...
 
 */
namespace New_Program1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*string miString = "15";
            string miString2 = "10";

            // Convertir de string a int

            if (Int32.TryParse(miString, out int miInt)){
                Console.WriteLine("Se ha transformado el string a integer: " + miInt);
            } else
            {
                Console.WriteLine("No se pudo transformar");
            }

            float miInt2 = Int32.Parse(miString2);

            Console.Write("Este es el valor de sumar cadenas: ");
            Console.WriteLine(miString + miString2);
            Console.Write("Este es el valor de sumar variables numericas: ");

            Console.WriteLine(miInt + miInt2);*/

            // Desafio del curso
            // Definimos el saludo inicial

            string saludo = "Por favor, ingresa tu nombre y presiona Enter: "; // Variable para almacenar el saludo inicial
            string username; // Variable para almacenar el nombre del usuario
            Console.Write(saludo); // Mostramos el saludo inicial
            username = Console.ReadLine(); // Leemos el nombre del usuario

            Console.WriteLine(username.ToUpper()); // Mostramos el nombre en mayúsculas
            Console.WriteLine(username.ToLower()); // Mostramos el nombre en minúsculas

            username = username.Trim(); // Eliminamos espacios al inicio y al final del nombre
            Console.WriteLine(username); // Mostramos el nombre sin espacios al inicio y al final

            Console.WriteLine(username.Substring(2)); // Mostramos el nombre desde el tercer carácter en adelante





        }
    }
}
