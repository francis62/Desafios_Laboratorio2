using System;
using System.Collections.Generic;
using System.Text;

namespace ElSoldado
{
    class Rifle : Arma
    {
        public override void disparar()
        {
            Console.WriteLine("Púm púm púm!...");
            Console.WriteLine("Púm púm púm!...");
            Console.WriteLine("Púm púm púm!...");
        }
    }
}
