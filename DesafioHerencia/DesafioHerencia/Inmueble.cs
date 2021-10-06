using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioHerencia
{
    class Inmueble
    {
        //Atributos de Inmueble
        String direccionInmueble;
        float metrosCuadradosInmueble;
        float precioSegunAntiguedad;

        public virtual float CalcularPrecioFinal()
        {
            return precioSegunAntiguedad;
        }
    }
}

