using System;

namespace Herencia
{
    class Program
    {

        static void Main(string[] args)
        {
            // Crear una instancia de la clase publicación
            Publicacion post1 = new Publicacion("Mi primer post", "Juan Pérez", true);

            // Mostrar la información de la publicación
            Console.WriteLine("Información de la publicación:");
            Console.WriteLine(post1.ToString()); // Llama al método ToString() de la clase Publicacion

            // Editar la publicación
            post1.Editar("Mi primer post editado", "Juan Pérez", true);

            // Mostrar la información de la publicación
            Console.WriteLine(post1.ToString());

            PublicacionImagen imagen1 = new PublicacionImagen("Mira mi nuevo perrito", "Juan Pérez", "https://imagen.com/perrito", true);

            // Mostrar la información de la publicación de imagen
            Console.WriteLine("Información de la publicación de imagen:");
            Console.WriteLine(imagen1.ToString()); // Llama al método ToString() de la clase PublicacionImagen, no de la clase Publicacion

            // Mostrar la URL de la imagen
            Console.WriteLine($"URL de la imagen: {imagen1.UrlImage}");

            // Editar la publicación de imagen
            imagen1.Editar("Mira mi nuevo perrito editado", "Juan Pérez", true);

            // Mostrar la información de la publicación de imagen editada
            Console.WriteLine(imagen1.ToString());
            // Mostrar la URL de la imagen editada
            Console.WriteLine($"URL de la imagen editada: {imagen1.UrlImage}");

        }

    }
}
