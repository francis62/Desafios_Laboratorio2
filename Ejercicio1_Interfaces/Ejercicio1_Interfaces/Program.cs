using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Contrato nuevoContrato = new Contrato();
            Foto nuevaFoto = new Foto();
            Documento nuevoDocumento = new Documento();

            Impresora nuevaImpresora = new Impresora(nuevoContrato, nuevaFoto, nuevoDocumento);

            nuevaImpresora.LlenadoDeColaDeImpresion();
            nuevaImpresora.ImprimirTodo();
            Console.ReadKey();
        }
    }
}
