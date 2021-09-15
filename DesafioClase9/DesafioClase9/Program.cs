using System;

namespace DesafioClase9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al programa de la calculadora");
            Console.WriteLine("DATOS DE LA SUMA:");
            Operacion.sumar();

            Console.WriteLine("DATOS DE LA RESTA:");
            Operacion.restar();
        }
    }
}
