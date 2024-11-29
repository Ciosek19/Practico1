using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Matriz
    {
        private int filas;
        private int columnas;
        private int cantidadValores;
        private int[] valores;

        public Matriz(int filas, int columnas)
        {
            this.filas = filas;
            this.columnas = columnas;
            this.cantidadValores = filas * columnas;
            valores = new int[cantidadValores];
            RellenarValores();
        }

        public void RellenarValores()
        {
            for (int i = 0; i < valores.Length; i++)
            {
                Random random = new Random();
                this.valores[i] = random.Next(-5, 5);
                Thread.Sleep(500);
            }
        }

        public int getValor(int fila, int columna)
        {
            return valores[(fila * columna) + columna];
        }

        public string SumarMatriz(Matriz matriz)
        {
            if (this.columnas != matriz.columnas || this.filas != matriz.filas)
            {
                return "No tienen las mismas dimensiones";
            }
            else
            {
                StringBuilder resultado = new StringBuilder();
                for (int i = 0; i < this.valores.Length; i++)
                {
                    int suma = matriz.valores[i] + this.valores[i];
                    //resultado.AppendLine($"Array[{i}]({this.valores[i]}) + Array[{i}]({matriz.valores[i]}) = {suma}");
                }
                return resultado.ToString();
            }
        }
    }

}
