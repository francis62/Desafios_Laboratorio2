using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioElectrodomesticos
{
    class Television : Electrodomestico
    {
        private int resolucion = 20;
        private Boolean sintonizadorTDT = false;

        Boolean validacionPrecio = false;
        Boolean validacionPeso = false;
        Boolean validacionConsumo = false;
        Boolean validacionResolucion = false;

        public Television()
        {

        }
        public Television(double precioBase, float peso)
        {
            this.precioBase = precioBase;
            this.pesoElectrodomestico = peso;
        }

        public Television(int resolucion, Boolean sintonizador, double precioBase, string color, string consumoEnergetico, float peso)
        {
            this.resolucion = resolucion;
            this.sintonizadorTDT = sintonizador;
            this.precioBase = precioBase;
            this.colorElectrodomestico = color;
            this.consumoEnergetico = consumoEnergetico;
            this.pesoElectrodomestico = peso;
        }

        public int GetResolucion
        {
            get => resolucion;
        }
        public Boolean GetSintonizador
        {
            get => sintonizadorTDT;
        }

        public override void precioFinal()
        {
            float precioSegunConsumo = 0;
            float precioSegunPeso = 0;
            double precioSegunResolucion = 0;
            double aux = 0.30;

            //PRECIO SEGUN RESOLUCION DE LA TELEVISION
            if (resolucion > 40)
            {
                precioSegunResolucion = precioBase + (precioBase * aux);
            }

            //PRECIO SEGUN CONSUMO ENERGETICO
            if (consumoEnergetico == "A" || consumoEnergetico == "a")
            {
                precioSegunConsumo = 100;
            }
            else if (consumoEnergetico == "B" || consumoEnergetico == "b")
            {
                precioSegunConsumo = 80;
            }
            else if (consumoEnergetico == "C" || consumoEnergetico == "c")
            {
                precioSegunConsumo = 60;
            }
            else if (consumoEnergetico == "D" || consumoEnergetico == "d")
            {
                precioSegunConsumo = 50;
            }
            else if (consumoEnergetico == "E" || consumoEnergetico == "e")
            {
                precioSegunConsumo = 30;
            }
            else
            {
                precioSegunConsumo = 10;
            }

            //PERCIO SEGUN PESO DEL ELECTRODOMESTICO
            if (pesoElectrodomestico > 0 && pesoElectrodomestico <= 19)
            {
                precioSegunPeso = 10;
            }
            else if (pesoElectrodomestico >= 20 && pesoElectrodomestico <= 49)
            {
                precioSegunPeso = 50;
            }
            else if (pesoElectrodomestico >= 50 && pesoElectrodomestico <= 79)
            {
                precioSegunPeso = 80;
            }
            else if (pesoElectrodomestico >= 80)
            {
                precioSegunPeso = 100;
            }

            //CALCULO PRECIO TOTAL
            precioTotal = precioSegunConsumo + precioSegunPeso + precioSegunResolucion + precioBase;

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("El precio final de este televisor es de $" + precioTotal);
            Console.WriteLine("--------------------------------------------------------------");
        }

        public void agregarTelevision()
        {
            //INGRESO DEL PRECIO BASE
            while (!validacionPrecio)
            {
                try
                {
                    Console.WriteLine("Ingrese el precio base del televisor:");
                    validacionPrecio = double.TryParse(Console.ReadLine(), out precioBase);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            //INGRESO DEL PESO
            while (!validacionPeso)
            {
                try
                {
                    Console.WriteLine("Ingrese el peso del televisor:");
                    validacionPeso = float.TryParse(Console.ReadLine(), out pesoElectrodomestico);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            //INGRESO DEL CONSUMO
            do
            {
                Console.WriteLine("Ingrese el consumo energetico de la lavadora");
                Console.WriteLine("(A - B - C - D - E - F)");
                consumoEnergetico = Console.ReadLine();

                if (consumoEnergetico.Length == 1)
                {
                    validacionConsumo = true;
                }
                else
                {
                    validacionConsumo = false;
                }

            } while (!validacionConsumo);


            //INGRESO DE LA RESOLUCION
            while (!validacionResolucion)
            {
                try
                {
                    Console.WriteLine("Ingrese la resolucion del televisor:");
                    validacionResolucion = int.TryParse(Console.ReadLine(), out resolucion);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
