using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioElectrodomesticos
{
    class Lavadora : Electrodomestico
    {
        //ATRIBUTO/S PROPIOS DE LA CLASE LAVADORA
        private float cargaLavadora = 5;

        //CONSTRUCTORES
        public Lavadora()
        {
        }

        public Lavadora(float precioBase, float peso)
        {
            this.precioBase = precioBase;
            this.pesoElectrodomestico = peso;
        }

        public Lavadora(float cargaLavadora, float precioBase, string color, string consumoEnergetico, float peso)
        {
            this.cargaLavadora = cargaLavadora;
            this.precioBase = precioBase;
            this.colorElectrodomestico = color;
            this.consumoEnergetico = consumoEnergetico;
            this.pesoElectrodomestico = peso;
        }

        //METODOS
        public float GetCarga
        {
            get => cargaLavadora;
        }

        public override void precioFinal()
        {
            double precioSegunConsumo = 0;
            double precioSegunPeso = 0;
            double precioSegunCarga = 0;

            //PRECIO SEGUN CARGA DE LA LAVADORA
            if (cargaLavadora > 30)
            {
                precioSegunCarga = precioBase + 50;
            }
            else
            {
                precioSegunCarga = precioBase;
            }

            //PRECIO SEGUN EL CONSUMO ENERGETICO
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

            //PRECIO SEGUN EL PESO DEL ELECTRODOMESTICO
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
            precioTotal = precioSegunConsumo + precioSegunPeso + precioSegunCarga;

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("El precio final de esta lavadora es de $" + precioTotal);
            Console.WriteLine("--------------------------------------------------------------");
        }

        public void agregarLavadora()
        {
            Boolean validacionPrecio = false;
            Boolean validacionPeso = false;
            Boolean validacionConsumo = false;
            Boolean validacionCarga = false;

            //INGRESO DEL PRECIO
            while (!validacionPrecio)
            {
                try
                {
                    Console.WriteLine("Ingrese el precio base la lavadora:");
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
                    Console.WriteLine("Ingrese el peso la lavadora:");
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
            

            //INGRESO DE LA CARGA
            while (!validacionCarga)
            {
                try
                {
                    Console.WriteLine("Ingrese la carga de la lavadora:");
                    validacionCarga = float.TryParse(Console.ReadLine(), out cargaLavadora);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
