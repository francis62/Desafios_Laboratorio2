using System;
using System.Collections.Generic;
using System.Text;

namespace ElSoldado
{
    abstract class Arma
    {
        private String modelo;
        private String material;

        public abstract void disparar();
    }
}
