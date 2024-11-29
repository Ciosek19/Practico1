using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector vector1 = new Vector(1, 2, 3);
            Vector vector2 = new Vector(-2, 1, 3);

            Console.WriteLine(vector1.CalcularDistancia(vector2));
            Console.ReadKey();
        }
    }
}
