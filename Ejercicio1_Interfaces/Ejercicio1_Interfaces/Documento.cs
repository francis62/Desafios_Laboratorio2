using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Interfaces
{
    class Documento : Imprimible
    {
        public void imprimir()
        {
            Console.WriteLine("Soy un documento de word");
        }
    }
}
