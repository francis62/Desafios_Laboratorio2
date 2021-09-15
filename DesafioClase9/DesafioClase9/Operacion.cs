using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioClase9
{
    static class Operacion
    {
        static private int resultadoSuma = 0;
        static private int resultadoResta = 0;

        public static void sumar()
        {
            int primerSumando;
            int segundoSumando;

            Console.WriteLine("Ingrese el primer sumando");
            primerSumando = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo sumando");
            segundoSumando = int.Parse(Console.ReadLine());

            resultadoSuma = primerSumando + segundoSumando;

            Console.WriteLine("El resultado de la suma es: {0}", resultadoSuma);
        }

        public static void restar()
        {
            int minuendo;
            int sustraendo;

            Console.WriteLine("Ingrese el primer numero correspondiente al minuendo");
            minuendo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero correspondiente al sustraendo");
            sustraendo = int.Parse(Console.ReadLine());

            resultadoResta = minuendo - sustraendo;

            Console.WriteLine("El resultado de la resta es: {0}", resultadoResta);
        }
    }
}
