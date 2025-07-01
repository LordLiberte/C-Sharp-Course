using System;

/*
 
 Los métodos son bloques de código que contienen una serie de instrucciones. El programa ejecuta estos con los argumentos necesarios
 que en C# todas las instrucciones trabajan en métodos. Por ejemplo Main es el punto de entrada para cada aplicación de C# y se le llama
 usando el Common Language Runtime (CLR)

 La sintaxis del metodo es:

    [modificador de acceso] [tipo de retorno] NombreMetodo([parametros])
    {
        // Cuerpo del metodo
        return valor; // si el tipo de retorno no es void
    }

 Con el modificador de acceso definimos la visibilidad del método como public, private, protected... El tipo de retorno viene a decir que es lo que devuelve.
 Supongamos que un método devuelve el nombre de una persona, entonces el tipo de retorno es string. Si no devuelve nada, se usa void.
 El nombre del método sigue la convensión de PascalCase, es decir, la primera letra de cada palabra en mayúscula. Y los parámetros
 son opcionales, pero si se usan deben estar separados por comas. Los parámetros son variables que se pasan al método para que este pueda trabajar con ellas.
 El cuerpo contiene las instrucciones que se ejecutan cuando se llama al método. 
 !!!! --> Si el tipo de retorno no es void, se debe usar la palabra clave return <-- !!!!

*/


namespace Metodos
{
    internal class Program
    {

        // args es un parámetro que recibe el método Main, que es un array de strings. 
        static void Main(string[] args)
        {

            string nombre1 = "Carlos";
            string nombre2 = "Ingrid";
            string nombre3 = "Arturo";

            SaludarAmigo(nombre2);
            // Llamada al método Sumar
            int suma = Sumar(5, 10);
            // Imprimir el resultado
            Console.WriteLine($"La suma es: {suma}");
            Console.ReadKey();
            // Llamada al método Saludar
            Saludar("Carlos"); // Para llamar al metodo desde un método static debe ponerse static en el metodo a llamar
            // Llamada al método EscribeAlgoEspecifico
            EscribeAlgoEspecifico("Este es un mensaje específico.");



        }

        public static int Sumar(int a, int b)
        {
            return a + b;
        }

        public static void Saludar(string nombre)
        {
            // Este método no devuelve nada, por lo que su tipo de retorno es void
            Console.WriteLine($"Hola, {nombre}!");
        }

        public static void EscribeAlgoEspecifico(string miTexto)
        {
            Console.WriteLine(miTexto);
            Console.Read();
            Multiplicar(3, 5);
            Dividir(10, 2);
            Dividir(10, 0); // Esto mostrará un mensaje de error porque no se puede dividir por cero

        }

        public static void Multiplicar(int a, int b)
        {
            int resultado = a * b;
            Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
        }

        public static void Dividir(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("No se puede dividir por cero. El segundo valor debe ser mayor a 0.");
            }

            if (b!= 0) 
            {
                Console.WriteLine(a / b);
            }
        }


        // Desafio

        public static void SaludarAmigo(string nombre)
        {
            Console.WriteLine($"Hola {nombre}, que tengas un buen día!");
            Console.Read();
        }
    }
}
