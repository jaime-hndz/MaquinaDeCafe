using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe
{
    internal class Azucarero
    {
        private int cantidadAzucar;


        public Azucarero (int cAzucar)
        {
            this.cantidadAzucar = cAzucar;
        }

        public void setCantidadAzucar(int cantidad)
        {
            this.cantidadAzucar = cantidad;
        }

        public int getCantidadAzucar()
        {
            return cantidadAzucar;
        }


        public bool hasAzucar(int cantidad)
        {
            if (cantidadAzucar >= cantidad)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void giveAzucar(int cantidad)
        {
            this.cantidadAzucar -= cantidad;
        }
    }
}
