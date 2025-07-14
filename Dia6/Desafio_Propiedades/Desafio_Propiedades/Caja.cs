using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Propiedades
{
    internal class Caja
    {

        // Propiedades publicas para definir las dimensiones de la caja
        public int Largo { get; set; }
        public int Ancho { get; set; }

        // Propiedad que calcula la superficie frontal de la caja
        public int SuperficieFrontal 
        {
            get
            {
                if (Largo > 0 && Ancho > 0)
                {
                    return Largo * Ancho;
                }
                else
                {
                    return 0;
                }
            }
        }

        // Método para mostrar la información de la caja
        public string MostrarInfo() 
        { 
            return $"Largo: {Largo}, Ancho: {Ancho}, Superficie Frontal: {SuperficieFrontal}";  // SuperficieFrontal se calcula automáticamente
        }
    }
}

