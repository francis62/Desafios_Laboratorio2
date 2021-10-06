using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioHerencia
{
    class Piso : Inmueble
    {
        int numeroDePiso;
        int antiguedad;
        float precioBase;
        float precioSegunPiso;

        public Piso(int numeroDePiso, float precioBase, int años)
        {
            this.numeroDePiso = numeroDePiso;
            this.precioBase = precioBase;
            this.antiguedad = años;
        }

        public void CalcularPrecioSegunPiso()
        {
            if (numeroDePiso >= 3)
            {
                precioSegunPiso = (float)(precioBase + (precioBase * 0.03));
            }
            else
            {
                precioSegunPiso = precioBase;
            }
        }

        public override float CalcularPrecioFinal()
        {
            float precioFinal;

            if (antiguedad < 15)
            {
                precioFinal = (float)(precioSegunPiso - (precioSegunPiso * 0.01));
            }
            else
            {
                precioFinal = (float)(precioSegunPiso - (precioSegunPiso * 0.02));
            }

            return precioFinal;
        }
    }
}


