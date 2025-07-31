namespace Herencia
{
    internal class Publicacion
    {

        private static int PublicacionID;


        // Propiedades de la clase
        protected int ID { get; set; }
        protected string Titulo { get; set; }
        protected string Autor { get; set; }
        protected bool esPublico { get; set; }


        // Constructor por defecto
        public Publicacion()
        {
            ID = CrearID();
            Titulo = "Mi primera publicación";
            Autor = "Juan Pérez";
            esPublico = true;
        }

        // Constructor parametrizado
        public Publicacion(string titulo, string autor, bool esPublico)
        {
            this.ID = CrearID();
            this.Titulo = titulo;
            this.Autor = autor;
            this.esPublico = esPublico;
        }

        // Método para crear ID

        protected int CrearID()
        {
            return ++PublicacionID;
        }

        // Método para editar publicación
        public void Editar(string titulo, string autor, bool esPublico)
        {
            this.Titulo = titulo;
            this.esPublico = esPublico;
        }

        // Override es para indicar que se va a sobrescribir un método de la clase base
        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Titulo} - Creado por {this.Autor}");
        }
    }
}
