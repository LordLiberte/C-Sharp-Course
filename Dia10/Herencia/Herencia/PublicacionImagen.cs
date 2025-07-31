using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{

    // Al poner ":" luego de la clase se indica que PublicacionImagen hereda de Publicacion
    internal class PublicacionImagen: Publicacion
    {
        // Propiedad nueva de la clase PublicacionImagen
        public string UrlImage { get; set; }

        // Constructor por defecto
        public PublicacionImagen() { }

        // Constructor parametrizado
        public PublicacionImagen(string titulo, string autor, string urlImage, bool esPublico) 
        {
            this.ID = CrearID(); // Herencia del método CrearID de la clase base Publicacion
            this.Titulo = titulo; // Herencia de la propiedad Titulo de la clase base Publicacion
            this.Autor = autor; // Herencia de la propiedad Autor de la clase base Publicacion
            this.UrlImage = urlImage;
            this.esPublico = esPublico; // Herencia de la propiedad esPublico de la clase base Publicacion
        }

        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Titulo} - Creado por {this.Autor} en {this.UrlImage}");
        }
    }
}
