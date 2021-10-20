using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioElectrodomesticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroUno = 0;

            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
            Console.WriteLine("<Bienvenido a la calculadora de precios de electrodomésticos<");
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
            Console.WriteLine("");

            //LISTA DE ELECTRODOMESTICOS
            List<Electrodomestico> listaDeElectrodomesticos = new List<Electrodomestico>();

            //CREACION DE OBJETOS
            Electrodomestico primerElectrodomestico = new Electrodomestico();
            Electrodomestico segundoElectrodomestico = new Electrodomestico(100,"negro","E",100);
            Lavadora primeraLavadora = new Lavadora(35,150,"negro","F",85);
            Lavadora segundaLavadora = new Lavadora(160, 200);
            Television primerTelevisor = new Television(500, 25);
            Television segundoTelevisor = new Television(50,false,1000,"azul","A",40);

            //AGREGAMOS LOS OBJETOS A LA LISTA
            listaDeElectrodomesticos.Add(primerElectrodomestico);
            listaDeElectrodomesticos.Add(segundoElectrodomestico);
            listaDeElectrodomesticos.Add(primerTelevisor);
            listaDeElectrodomesticos.Add(segundoTelevisor);
            listaDeElectrodomesticos.Add(primeraLavadora);
            listaDeElectrodomesticos.Add(segundaLavadora);

            do
            {
                double sumatoriaTotalPrecios = 0;
                int numeroDos = 0;
                Boolean validacionNumeroMenuDos = false;
                Boolean validacionNumeroMenuUno = false;

                //MENU PRINCIPAL
                while (!validacionNumeroMenuUno)
                {
                    Console.WriteLine("***********************************************");
                    Console.WriteLine("Seleccione una opcion:");
                    Console.WriteLine("");
                    Console.WriteLine("1 -> Agregar electrodomesticos");
                    Console.WriteLine("2 -> Observar los electrodomesticos ya cargados");
                    Console.WriteLine("3 -> Salir del programa");
                    Console.WriteLine("***********************************************");
                    validacionNumeroMenuUno = int.TryParse(Console.ReadLine(), out numeroUno);

                    if (!validacionNumeroMenuUno)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Caracter invalido...");
                        Console.WriteLine("Ingreselo nuevamente");
                        Console.WriteLine("");
                    }
                }

                if (numeroUno == 1)
                {
                    while (!validacionNumeroMenuDos)
                    {
                        Console.WriteLine("***********************************************");
                        Console.WriteLine("Ingrese el tipo de electrodomestico a cotizar");
                        Console.WriteLine("1 -> Televisor");
                        Console.WriteLine("2 -> Lavadora");
                        Console.WriteLine("3 -> Electrodomestico en general");
                        Console.WriteLine("***********************************************");
                        validacionNumeroMenuDos = int.TryParse(Console.ReadLine(), out numeroDos);

                        if (!validacionNumeroMenuDos)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Caracter invalido...");
                            Console.WriteLine("Ingreselo nuevamente");
                            Console.WriteLine("");
                        }
                    }

                    if (numeroDos == 1)
                    {
                        Television televisor = new Television();

                        televisor.agregarTelevision();
                        televisor.precioFinal();
                        listaDeElectrodomesticos.Add(televisor);
                        Console.ReadKey();
                    }
                    else if (numeroDos == 2)
                    {
                        Lavadora lavadora = new Lavadora();

                        lavadora.agregarLavadora();
                        lavadora.precioFinal();
                        listaDeElectrodomesticos.Add(lavadora);
                        Console.ReadKey();
                    }
                    else
                    {
                        Electrodomestico electrodomestico = new Electrodomestico();

                        electrodomestico.agregarElectrodomestico();
                        electrodomestico.precioFinal();
                        listaDeElectrodomesticos.Add(electrodomestico);
                        Console.ReadKey();
                    }
                }
                else if (numeroUno == 2)
                {
                    //RECORREMOS EL ARRAY PARA MOSTRAR LOS PRECIOS FINALES
                    foreach (Electrodomestico e in listaDeElectrodomesticos)
                    {
                        e.precioFinal();

                        sumatoriaTotalPrecios = sumatoriaTotalPrecios + e.retornarPrecioTotal();
                    }

                    Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
                    Console.WriteLine("<La sumatoria total de todos los electrodomesticos es de: $" + sumatoriaTotalPrecios + "<");
                    Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Saliendo del programa...");
                    Console.ReadKey();
                }
            } while (numeroUno != 3);
        }
    }
}
