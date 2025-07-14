using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_Propiedades
{
    internal class Automovil
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public string identificacion { get; set; }
        private int anio;

        public int Anio
        {
            get
            {
                return anio;
            }

            set
            {
                if (anio > 1990)
                {
                    anio = value;
                }
                else
                {
                    throw new Exception("El automovil es muy antiguo");
                }
            }
        }


        public Automovil()
        {
            this.marca = "";
            this.modelo = "";
            this.identificacion = "";
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("{0} {1} - {2}", marca, modelo, identificacion);
        }

    }
}
