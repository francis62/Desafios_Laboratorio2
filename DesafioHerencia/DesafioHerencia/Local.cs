using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioHerencia
{
    class Local : Inmueble
    {
        int numeroDeVentanas;
        int superficieLocal;
        int antiguedadLocal;
        float precioBase;
        float precioSegunSuperficie;
        float precioSegunVentanales;

        public Local(int numeroDeVentanas, float precioBase, int superficie, int años)
        {
            this.numeroDeVentanas = numeroDeVentanas;
            this.precioBase = precioBase;
            this.superficieLocal = superficie;
            this.antiguedadLocal = años;
        }

        public void CalcularPrecioSegunSuperficie()
        {
            if (superficieLocal > 50)
            {
                precioSegunSuperficie = (float)(precioBase + (precioBase * 0.01));
            }
            else
            {
                precioSegunSuperficie = precioBase;
            }
        }

        public void CalcularPrecioSegunVentanales()
        {
            if (numeroDeVentanas == 1 || numeroDeVentanas == 0)
            {
                precioSegunVentanales = (float)(precioSegunSuperficie - (precioSegunSuperficie * 0.02));
            }
            else if (numeroDeVentanas > 4) 
            {
                precioSegunVentanales = (float)(precioSegunSuperficie + (precioSegunSuperficie * 0.02));
            }
            else
            {
                precioSegunVentanales = precioSegunSuperficie;
            }
        }

        public override float CalcularPrecioFinal()
        {
            float precioFinal;

            if (antiguedadLocal < 15)
            {
                precioFinal = (float)(precioSegunVentanales - (precioSegunVentanales * 0.01));
            }
            else
            {
                precioFinal = (float)(precioSegunVentanales - (precioSegunVentanales * 0.02));
            }

            return precioFinal;
        }
    }
}

