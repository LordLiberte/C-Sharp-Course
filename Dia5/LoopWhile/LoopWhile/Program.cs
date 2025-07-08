using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int contador = 0;
            string nombre = "";
            bool esNumero = false;

            while (contador < 10)
            {
                nombre = Console.ReadLine();
                if (nombre != "") {

                    esNumero = int.TryParse(nombre, out int numero);
                    if (esNumero)
                    {
                        Console.WriteLine("El nombre no puede ser un número");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("El nombre del alumno es: " + nombre);
                        contador++;
                    }
                   
                }
                else
                {
                    Console.WriteLine("No has introducido un nombre");
                }
                Console.WriteLine("Tienes {0} alumnos", contador);
        
            }

            Console.WriteLine("Has introducido {0} alumnos", contador);
            Console.WriteLine("El bus está lleno");
        }
    }
}
