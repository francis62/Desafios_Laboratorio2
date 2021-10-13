using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Pato nuevoPato = new Pato();
            Boing747 nuevoBoing = new Boing747();
            Superman nuevoSuperman = new Superman();

            TorreDeControl nuevaTorreDeControl = new TorreDeControl(nuevoPato, nuevoBoing, nuevoSuperman);

            nuevaTorreDeControl.LlenarTorreDeControl();
            nuevaTorreDeControl.vuelenTodos();
            Console.ReadKey();
        }
    }
}
