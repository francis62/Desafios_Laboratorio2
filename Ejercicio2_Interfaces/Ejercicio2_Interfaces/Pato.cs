using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Interfaces
{
    class Pato : Animal , Volador
    {
        private int vidas = 100;

        public void volador()
        {
            Console.WriteLine("Estoy volando como un pato... ¡Cuak!");
            vidas = vidas - 5;
        }
    }
}
