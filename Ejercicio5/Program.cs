using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matriz matriz1 = new Matriz(2,5);
            Matriz matriz2 = new Matriz(3,5);
            
            Matriz matriz3 = new Matriz(3,5);
            Matriz matriz4 = new Matriz(3,5);

            //Console.WriteLine(matriz1.SumarMatriz(matriz2));
            //Console.WriteLine(matriz3.SumarMatriz(matriz4));

            Console.ReadKey();
        }


    }
}
