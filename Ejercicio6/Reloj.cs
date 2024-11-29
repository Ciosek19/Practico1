using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Reloj
    {
        private int segundo;
        private int minuto;
        private int hora;

        public Reloj(int segundo, int minuto, int hora)
        {
            this.segundo = segundo;
            this.minuto = minuto;
            this.hora = hora;
        }

        public int getSegundo() { return segundo; }
        public int getMinuto() { return minuto; }
        public int getHora() { return hora; }

        public void setSegundo(int segundo) { this.segundo = segundo; this.minuto = 0; }
        public void setMinuto(int minuto) { this.minuto = minuto; }
        public void setHora(int hora) { this.hora = hora; }

        public string ObtenerHora()
        {
            return $"{hora}:{minuto}:{segundo}";
        }

        public string HoraSegunSegundos(int segundos)
        {
            for (int i = 0; i < segundos; i++)
            {
                if (i % 60 == 0)
                {
                    minuto++;
                }
                if (minuto % 60 == 0)
                {
                    hora++;
                }
            }

            return $"{dosDigitos(hora)}:{dosDigitos(minuto)}:{dosDigitos(segundo)}";
        }

        public string dosDigitos(int numero)
        {
            if (numero < 10)
            {
                return $"0{numero}";
            }
            return numero.ToString();
        }

        public string DiferenciaHoraria(Reloj reloj)
        {

            int segundos = 0;
            if (reloj.hora > 0)
            {
                segundos += reloj.hora * 3600;
            }
            if (reloj.minuto > 0)
            {
                segundos += reloj.minuto * 60;
            }
            if (reloj.segundo > 0)
            {
                segundos += reloj.segundo;
            }
            return HoraSegunSegundos(segundos);
        }
    }
}
