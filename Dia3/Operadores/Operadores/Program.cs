using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1 = 5;
            int num2 = 3;
            int num3;

            // Operadores Unarios
            num3 = -num1; // Negación
            Console.WriteLine($"Negación de {num1}: {num3}");


            bool haySol = true;
            Console.WriteLine($"¿Hay sol? {!haySol}"); // ! es la negación lógica

            // Operadores de adición
            int num = 0;
            num++;  // Suma 1 al numero
            Console.WriteLine(num);

            // Operadores de sustracción
            num--; // Resta 1 al numero
            Console.WriteLine(num);

            // Operadores matematicos
            int resultado = num1 + num2; // Suma
            Console.WriteLine($"El resultado de la suma entre {num1} y {num2} es igual a {resultado}");

            resultado = num1 - num2; // Resta
            Console.WriteLine($"El resultado de la resta de {num1} y {num2} es igual a {resultado}");

            resultado = num1 * num2; // Multiplicación
            Console.WriteLine($"El resultado de la multiplicación de {num1} y {num2} es igual a {resultado}");

            float resultadoDivision = (float)num1 / (float)num2; // División con num2 > 0
            Console.WriteLine($"El resultado de la división entre {num1} y {num2} es igual a {resultadoDivision}");

            resultado = num1 % num2; // Módulo
            Console.WriteLine($"El resultado del módulo entre {num1} y {num2} es igual a {resultado}");


            // Operadores relacionales
            bool esMenor;
            esMenor = num1 < num2; // Menor que
            Console.WriteLine($"{num1} es menor que {num2}: {esMenor}");

            esMenor = num1 <= num2; // Menor o igual que
            Console.WriteLine($"{num1} es menor o igual que {num2}: {esMenor}");

            esMenor = num1 > num2; // Mayor que
            Console.WriteLine($"{num1} es mayor que {num2}: {esMenor}");

            esMenor = num1 >= num2; // Mayor o igual que
            Console.WriteLine($"{num1} es mayor o igual que {num2}: {esMenor}");

            esMenor = num1 == num2; // Igual que
            Console.WriteLine($"{num1} es igual a {num2}: {esMenor}");

            esMenor = num1 != num2; // Diferente de
            Console.WriteLine($"{num1} es diferente de {num2}: {esMenor}");

            // Operadores condicionales 
            // AND Lógico

            bool esMenorySoleado;

            esMenorySoleado = esMenor && haySol; // AND Lógico
            Console.WriteLine($"¿Es {num1} menor que {num2} y hay sol? {esMenorySoleado}");



            // OR Lógido

            bool esMenoroSoleado;

            esMenoroSoleado = esMenor || haySol; // OR Lógico
            Console.WriteLine($"¿Es {num1} menor que {num2} o hay sol? {esMenoroSoleado}");


        }
    }
}
