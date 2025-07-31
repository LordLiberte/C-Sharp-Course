using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class PublicacionVideo : Publicacion
    {

        public PublicacionVideo() { }

        public string UrlVideo { get; set; }
        public int Duracion { get; set; }

        public PublicacionVideo(string titulo, string autor, string urlVideo, bool esPublico, int duracion)
        {
            this.UrlVideo = urlVideo;
            this.Autor = autor;
            this.Titulo = titulo;
            this.esPublico = esPublico;
            this.ID = CrearID();
            this.Duracion = duracion;
        }

        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Titulo} - Creado por {this.Autor} en {this.UrlVideo} con duración de {this.Duracion}");
        }
    }
}
