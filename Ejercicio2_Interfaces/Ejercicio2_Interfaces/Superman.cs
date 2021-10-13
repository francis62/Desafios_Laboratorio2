using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Interfaces
{
    class Superman : SuperHeroe, Volador
    {
        private int experiencia = 0;

        public void volador()
        {
            Console.WriteLine("Estoy volando como un campeón...");
            experiencia = experiencia + 3;
        }
    }
}
