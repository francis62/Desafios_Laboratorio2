using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Interfaces
{
    class Impresora
    {
        private Contrato nuevoContrato;
        private Foto nuevaFoto;
        private Documento nuevoDocumento;

        public Impresora(Contrato nuevoContrato, Foto nuevaFoto, Documento nuevoDocumento)
        {
            this.nuevoContrato = nuevoContrato;
            this.nuevaFoto = nuevaFoto;
            this.nuevoDocumento = nuevoDocumento;
        }

        List<Imprimible> ColaDeImpresion = new List<Imprimible>();

        public void LlenadoDeColaDeImpresion()
        {
            ColaDeImpresion.Add(nuevaFoto);

            ColaDeImpresion.Add(nuevoDocumento);

            ColaDeImpresion.Add(nuevoContrato);
        }

        public void ImprimirTodo()
        {
            foreach(Imprimible e in ColaDeImpresion)
            {
                e.imprimir();
            }
        }

        public void AgregarImprimible(Imprimible unImprimible)
        {
            ColaDeImpresion.Add(unImprimible);
        }
    }
}
