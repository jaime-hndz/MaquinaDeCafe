using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe
{
    internal class MaquinaDeCafe
    {
        Cafetera cafe;
        Vaso vasosPequeno;
        Vaso vasosMediano;
        Vaso vasosGrande;
        Azucarero azucarero;

        public void setCafetera(Cafetera caf)
        {
            cafe = caf;
        }
        public void setVasosPequeno(Vaso vaso)
        {
            vasosPequeno = vaso;
        }
        public void setVasosMediano(Vaso vaso)
        {
            vasosMediano = vaso;
        }
        public void setVasosGrande(Vaso vaso)
        {
            vasosGrande = vaso;
        }
        public void setAzucarero(Azucarero azu)
        {
            azucarero = azu;
        }

        public Vaso getTipoDeVaso(string tipo)
        {
            switch (tipo)
            {
                case "pequeno":
                    return vasosPequeno;
                case "mediano":
                    return vasosMediano;
                case "grande":
                    return vasosGrande;
                default:
                    return null;
            }
        }

        public string getVasoDeCafe(Vaso tipoDeVaso, int cantidadDeVasos, int cantidadDeAzucar)
        {
            if (tipoDeVaso.hasVasos(cantidadDeVasos))
            {
                if(cafe.hasCafe(tipoDeVaso.getContenido() * cantidadDeVasos))
                {
                    if (azucarero.hasAzucar(cantidadDeAzucar))
                    {
                        tipoDeVaso.giveVasos(cantidadDeVasos);
                        cafe.giveCafe(tipoDeVaso.getContenido() * cantidadDeVasos);
                        azucarero.giveAzucar(cantidadDeVasos);

                        return "Felicitaciones, aquí tiene tu/s café/s";
                    }
                    else
                    {
                        return "No hay azucar";
                    }
                }else
                {
                    return "No hay cafe";
                }
            }
            else
            {
                return "No hay vasos";
            }

        }


    }
}
