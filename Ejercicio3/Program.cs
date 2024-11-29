using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            Realice el código usando diagrama de clases, para poder imprimir la resta y la suma de dos vectores.  
            */
            Vector vector1 = new Vector(5,2,3);
            Vector vector2 = new Vector(2,1,7);

            Console.WriteLine(vector1.SumarVector(vector2));
            Console.WriteLine(vector2.RestarVector(vector1));
            Console.ReadKey();
        }
    }
}
