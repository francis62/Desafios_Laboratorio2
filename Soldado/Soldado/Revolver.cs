using System;
using System.Collections.Generic;
using System.Text;

namespace ElSoldado
{
    class Revolver : Arma
    {
        public override void disparar()
        {
            Console.WriteLine("Púm...");
            Console.WriteLine("Púm...");
            Console.WriteLine("Púm...");
        }
    }
}
