using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Interfaces
{
    class TorreDeControl
    {
        private Pato torreDeControlPato;
        private Boing747 torreDeControlBoing;
        private Superman torreDeControlSuperman;

        List<Volador> voladores = new List<Volador>();

        public TorreDeControl(Pato nuevoPato, Boing747 nuevoBoing, Superman nuevoSuperman)
        {
            this.torreDeControlPato = nuevoPato;
            this.torreDeControlBoing = nuevoBoing;
            this.torreDeControlSuperman = nuevoSuperman;
        }
        public void LlenarTorreDeControl()
        {
            voladores.Add(torreDeControlPato);

            voladores.Add(torreDeControlBoing);

            voladores.Add(torreDeControlSuperman);
        }

        public void vuelenTodos()
        {
            foreach(Volador e in voladores)
            {
                e.volador();
            }
        }

        public void agregarVolador(Volador unVolable)
        {
            voladores.Add(unVolable);
        }
    }
}
