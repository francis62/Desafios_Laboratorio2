using System;

namespace ElSoldado
{
    class Program
    {
        static void Main(string[] args)
        {
            Soldado sargento = new Soldado();

            int opcionElegida;

            do {
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("=== Bienvenido al campo de entrenamiento, Soldado ===");
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("");

                Console.WriteLine("¿Que desea hacer?");
                Console.WriteLine("PRESIONE EL NUMERO CORRESPONDIENTE A LA OPCION DE MENU");
                Console.WriteLine("");

                Console.WriteLine("1 -> Recoger arma.");
                Console.WriteLine("2 -> Dejar arma.");
                Console.WriteLine("3 -> Disparar.");
                Console.WriteLine("4 -> Ver arma en uso.");
                Console.WriteLine("5 -> Salir.");
                opcionElegida = int.Parse(Console.ReadLine());

                Console.WriteLine("");

                switch (opcionElegida)
                {
                    case 1:
                        sargento.recogerArma();
                        break;

                    case 2:
                        sargento.dejarArma();
                        break;

                    case 3:
                        sargento.disparar();
                        break;

                    case 4:
                        sargento.verArmaEnUso();
                        break;

                    case 5:
                        Console.WriteLine("Saliendo del campo de entrenamiento...");
                        break;
                }
            } while(opcionElegida != 5);        
        }
    }
}
