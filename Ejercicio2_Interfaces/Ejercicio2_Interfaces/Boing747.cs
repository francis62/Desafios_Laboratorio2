using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Interfaces
{
    class Boing747 : Aviones , Volador
    {
        private int horasDeVuelo = 0;

        public void volador()
        {
            Console.WriteLine("Estoy volando como un avión...");
            horasDeVuelo = horasDeVuelo + 13;
        }
    }
}
