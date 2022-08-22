using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe
{
    internal class Cafetera
    {
        private int cantidadCafe;


        public Cafetera(int cCafe)
        {
            cantidadCafe = cCafe;
        }

        public void setCantidadCafe(int cantidad)
        {
            this.cantidadCafe = cantidad;
        }

        public int getCantidadCafe()
        {
            return cantidadCafe;
        }


        public bool hasCafe(int cantidad)
        {
            if (cantidadCafe >= cantidad)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void giveCafe(int cantidad)
        {
            this.cantidadCafe -= cantidad;
        }
    }
}
