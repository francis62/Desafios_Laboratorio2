using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioElectrodomesticos
{
    class Electrodomestico
    {
        //ATRIBUTOS
        protected double precioBase = 100;
        protected String colorElectrodomestico = "blanco";
        protected String consumoEnergetico = "F";
        protected float pesoElectrodomestico = 5;
        protected double precioTotal;

        //CONSTRUCTORES
        public Electrodomestico() { 
        }

        public Electrodomestico(double precioBase, float peso)
        {
            this.precioBase = precioBase;
            this.pesoElectrodomestico = peso;
        }

        public Electrodomestico(double precioBase, string color, string consumoEnergetico, float peso)
        {
            this.precioBase = precioBase;
            this.colorElectrodomestico = color;
            this.consumoEnergetico = consumoEnergetico;
            this.pesoElectrodomestico = peso;
        }
        
        //METODOS 
        public double GetPrecioBase
        {
            get => precioBase;
        }
        public String GetColor
        {
            get => colorElectrodomestico;
        }
        public String GetConsumoEnergetico
        {
            get => consumoEnergetico;
        }
        public float GetPeso
        {
            get => pesoElectrodomestico;
        }

        private void comprobarConsumoEnergetico(String letra)
        {
            if (letra == "A" || letra == "a")
            {
                this.consumoEnergetico = letra;
            }
            else if(letra == "B" || letra == "b")
            {
                this.consumoEnergetico = letra;
            }
            else if (letra == "C" || letra == "c")
            {
                this.consumoEnergetico = letra;
            }
            else if (letra == "D" || letra == "d")
            {
                this.consumoEnergetico = letra;
            }
            else if (letra == "E" || letra == "e")
            {
                this.consumoEnergetico = letra;
            }
            else if (letra == "F" || letra == "f")
            {
                this.consumoEnergetico = letra;
            }
            else
            {
                letra = consumoEnergetico;
            }
        }
        private void comprobarColor(String color)
        {
            if (color == "blanco" || color == "Blanco" || color == "BLANCO")
            {
                this.colorElectrodomestico = color;
            }
            else if (color == "negro" || color == "Negro" || color == "NEGRO")
            {
                this.colorElectrodomestico = color;
            }
            else if (color == "rojo" || color == "Rojo" || color == "ROJO")
            {
                this.colorElectrodomestico = color;
            }
            else if (color == "azul" || color == "Azul" || color == "AZUL")
            {
                this.colorElectrodomestico = color;
            }
            else if (color == "gris" || color == "Gris" || color == "GRIS")
            {
                this.colorElectrodomestico = color;
            }
            else
            {
                color = colorElectrodomestico;
            }
        }
        public virtual void precioFinal()
        {
            float precioSegunConsumo = 0;
            float precioSegunPeso = 0;

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

            //CALCULO PREICO TOTAL
            precioTotal = precioSegunConsumo + precioSegunPeso + precioBase;

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("El precio final de este electrodomestico es de $" + precioTotal);
            Console.WriteLine("--------------------------------------------------------------");
        }
        public double retornarPrecioTotal()
        {
            return precioTotal;
        }

        public void agregarElectrodomestico()
        {
            Boolean validacionPeso = false;
            Boolean validacionConsumo = false;
            Boolean validacionPrecio = false;

            //INGRESO DEL PRECIO BASE
            while (!validacionPrecio)
            {
                try
                {
                    Console.WriteLine("Ingrese el precio base del electrodomestico:");
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
                    Console.WriteLine("Ingrese el peso del electrodomestico:");
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
        }

    }
}
