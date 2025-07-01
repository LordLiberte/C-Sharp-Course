using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeErrores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Porfavor, ingrese un número: ");
            // Leemos el input del usuario
            string input = Console.ReadLine();
  

            // Con try intentamos ejecutar el código y con catch capturamos cualquier excepción que ocurra
            try
            {
                // Intentamos convertir el input a un número entero
                int numero = int.Parse(input);
                Console.Read();

            }
            catch (FormatException)
            {
                 Console.WriteLine("El formato del número ingresado es incorrecto. Por favor, ingrese un número válido.");
            }
            catch (OverflowException)
            {
                // Si ocurre una excepción de formato, mostramos un mensaje al usuario
                Console.WriteLine("El número ingresado es demasiado grande o pequeño.");
            }
            catch (Exception ex)
            {
                // Capturamos cualquier otra excepción y mostramos su mensaje
                Console.WriteLine($"Ocurrió un error: {ex.Message}");
            }
            finally
            {
                // Este bloque se ejecuta siempre, haya ocurrido o no una excepción
                Console.WriteLine("Fin del programa.");
            }


        }


    }
}
