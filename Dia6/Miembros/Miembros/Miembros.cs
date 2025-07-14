using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miembros
{
    internal class Miembros
    {
        // Miembros - Campos privados
        private string nombrePersona;
        private string tituloTrabajo;
        private int salario;
        private string currency;

        // Miembros - Campos públicos
        public int Edad;
        public int NumeroIdentificacion;

        // Miembros - Propiedades
        public string TituloTrabajo 
        {
            get
            {
                return tituloTrabajo;
            }
            set
            {
                this.tituloTrabajo = value;
            }
        }

        // Miembros - Método privado
        private void CompartirInfoPrivada()
        {
            Console.WriteLine($"Hola mi salario es: {salario}");
        }

        // Miembros - Método público
        public void Amigo(bool esAmigo)
        {
            if (esAmigo)
            {
                Console.WriteLine($"Hola, mi nombre es {nombrePersona} y mi edad es de {Edad} años");
                CompartirInfoPrivada();
            }
            else
            {
                Console.WriteLine($"Hola, mi nombre es {nombrePersona} y mi edad es de {Edad} años");
            }
        }

        public Miembros(string nombrePersona, string tituloTrabajo, int salario, string currency, int edad, int ident)
        {
            this.nombrePersona = nombrePersona;
            this.tituloTrabajo = tituloTrabajo;
            this.salario = salario;
            // Inicialización de campos públicos
            this.Edad = edad;
            this.NumeroIdentificacion = ident;
            this.currency = currency;
            Console.WriteLine($"Miembro creado: {nombrePersona}, Título: {tituloTrabajo}, Salario: {salario}{currency}, Edad: {edad}, ID: {ident}");
        }

        // Miembros - Finalizador/Destructor

        ~Miembros()
        {
            // Aquí podrías liberar recursos si fuera necesario
            Debug.Write($"El miembro {nombrePersona} ha sido destruido.");  // En vez de en la consola, se usa Debug para evitar la salida en producción

        }
    }
}
