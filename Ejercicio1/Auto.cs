using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Auto
    {
        private int cantPuertas;
        private int anio;
        private string tapiceria;
        private string climatizador;

        public Auto(int cantPuertas, int anio, string climatizador, string tapiceria)
        {
            this.cantPuertas = cantPuertas;
            this.anio = anio;
            this.climatizador = climatizador;
            this.tapiceria = tapiceria;
        }

        public Auto(int cantPuertas, int anio, string climatizador)
        {
            this.cantPuertas = cantPuertas;
            this.anio = anio;
            this.climatizador = climatizador;
        }

        public Auto(int cantPuertas, string tapiceria)
        {
            this.cantPuertas = cantPuertas;
            this.tapiceria = tapiceria;
        }

        //Cantidad puertas
        public int getCantPuertas()
        {
            return cantPuertas;
        }
        public void setCantPuertas(int puertas)
        {
            this.cantPuertas = puertas;
        }

        //Anio
        public int getAnio()
        {
            return anio;
        }
        public void setAnio(int anio)
        {
            this.anio = anio;
        }

        //Tapiceria
        public string getTipoTapiceria()
        {
            return tapiceria;
        }
        public void setTipoTapiceria(string tapiceria)
        {
            this.tapiceria = tapiceria;
        }

        //Climatizador
        public string getClimatizador()
        {
            return climatizador;
        }
        public void setClimatizador(string climatizador)
        {
            this.climatizador = climatizador;
        }
    }
}
