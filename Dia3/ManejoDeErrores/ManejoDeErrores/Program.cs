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

            // Llamamos al método Dividir
            Dividir();

        }

        public static void Sumar()
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

        public static void Dividir()
        {
            // Inicializamos las variables para evitar el error CS0165
            int numero1 = 0, numero2 = 0;

            try
            {
                Console.Write("Porfavor, ingrese el primer número: ");
                numero1 = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("El formato del número ingresado es incorrecto. Por favor, ingrese un número válido.");
                return; // Salimos del método si hay un error de formato
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return; // Salimos del método si ocurre cualquier otra excepción
            }

            try
            {
                Console.Write("Porfavor, ingrese el segundo número: ");
                numero2 = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("El formato del número ingresado es incorrecto. Por favor, ingrese un número válido.");
                return; // Salimos del método si hay un error de formato
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return; // Salimos del método si ocurre cualquier otra excepción
            }

            try
            {
                int division = numero1 / numero2;
                Console.WriteLine($"El resultado de la división es: {division}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("No se puede dividir por cero. Por favor, ingrese un número diferente de cero.");
            } catch (Exception ex)
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
