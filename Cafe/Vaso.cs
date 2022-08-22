using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe
{
    internal class Vaso
    {
        private int cantidadVasos;
        private int contenido;

        public Vaso(int cVasos, int cont)
        {
            cantidadVasos = cVasos;
            contenido = cont;  
        }

        public void setCantidadVasos(int cantidad)
        {
            this.cantidadVasos = cantidad;
        }

        public int getCantidadVasos()
        {
            return cantidadVasos;
        }

        public void setContenido(int cantidad)
        {
            this.contenido = cantidad;
        }

        public int getContenido()
        {
            return contenido;
        }

        public bool hasVasos(int cantidad)
        {
            if (cantidadVasos >= cantidad)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void giveVasos(int cantidad)
        {
            this.cantidadVasos -= cantidad;
        }


    }
}
