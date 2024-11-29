using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Reloj reloj = new Reloj(0, 0, 0);

            Console.WriteLine(reloj.HoraSegunSegundos(120));
            Console.ReadKey();
        }
    }
}
