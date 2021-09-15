using System;
using System.Collections.Generic;
using System.Text;

namespace ElSoldado
{
    class Soldado
    {
        private int armaElegida;
        public static bool armaEnMano = false;
        public static int armaEnUso = 0;

        static public int getArmaEnUso
        {
            get
            {
                return armaEnUso;
            }
        }
        static public int setArmaEnUso
        {
            set
            {
                armaEnUso = value;
            }
        }

        static public bool getArmaEnMano
        {
            get
            {
                return armaEnMano;
            }
        }
        static public bool setArmaEnMano
        {
            set
            {
                armaEnMano = value;
            }
        }

        public void recogerArma()
        {
            Console.WriteLine("Por favor Soldado, escoja el arma que desea utilizar");
            Console.WriteLine("");
            Console.WriteLine("1 -> REVOLVER");
            Console.WriteLine("2 -> RIFLE");
            Console.WriteLine("3 -> ESCOPETA");
            Console.WriteLine("4 -> Volver atrás");
            armaElegida = int.Parse(Console.ReadLine());
            setArmaEnUso = armaElegida;

            Console.WriteLine("");

            switch (armaElegida)
            {
                case 1:
                    if(getArmaEnMano == false)
                    {
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("USTED HA ELEGIDO EL REVOLVER");
                        Console.WriteLine("----------------------------");
                        setArmaEnMano = true;
                    }
                    else
                    {
                        Console.WriteLine("Parece que el soldado ya tiene un arma en sus manos...");
                    }
                    
                    break;

                case 2:
                    if (getArmaEnMano == false)
                    {
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("USTED HA ELEGIDO EL RIFLE");
                        Console.WriteLine("-------------------------");
                        setArmaEnMano = true;
                    }
                    else
                    {
                        Console.WriteLine("Parece que el soldado ya tiene un arma en sus manos...");
                    }

                    break;

                case 3:
                    if (getArmaEnMano == false)
                    {
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("USTED HA ELEGIDO LA ESCOPETA");
                        Console.WriteLine("----------------------------");
                        setArmaEnMano = true;
                    }
                    else
                    {
                        Console.WriteLine("Parece que el soldado ya tiene un arma en sus manos...");
                    }

                    break;

                case 4:
                    Console.WriteLine("Volviendo al menú principal...");
                    setArmaEnUso = 0;
                    setArmaEnMano = false;
                    break;
            }
        }

        public void dejarArma()
        {
            if(getArmaEnMano == false)
            {
                Console.WriteLine("Parece que el soldado no tiene ningún arma en sus manos");
                Console.WriteLine("No puede dejar un arma si todavía no ha elegido alguna...");
            }
            else
            {
                Console.WriteLine("El soldado ha decidido dejar el arma...");
                setArmaEnMano = false;
                setArmaEnUso = 0;
            }
        }

        public void disparar()
        {
            if(getArmaEnUso == 0)
            {
                Console.WriteLine("Cuidado soldado, debe elejir un arma antes de disparar...");

            }else if(getArmaEnUso == 1)
            {
                Revolver revolver = new Revolver();
                revolver.disparar();

            }
            else if(getArmaEnUso == 2)
            {
                Rifle rifle = new Rifle();
                rifle.disparar();

            }
            else if(getArmaEnUso == 3)
            {
                Escopeta escopeta = new Escopeta();
                escopeta.disparar();
            }
        }

        public void verArmaEnUso()
        {
            if (Soldado.getArmaEnUso == 0)
            {
                Console.WriteLine("Parece que el soldado todavia no elije ningun arma");

            }
            else if (Soldado.getArmaEnUso == 1)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("El soldado tiene en sus manos un REVOLVER");
                Console.WriteLine("-----------------------------------------");
            }
            else if (Soldado.getArmaEnUso == 2)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("El soldado tiene en sus manos un RIFLE");
                Console.WriteLine("--------------------------------------");
            }
            else
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("El soldado tiene en sus manos una ESCOPETA");
                Console.WriteLine("------------------------------------------");
            }
        }

    }
}
