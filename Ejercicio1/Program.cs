using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto(4,"cuero");
            Auto auto2 = new Auto(4,2012,"atmosferico");
            Auto auto3 = new Auto(4,2012,"atmosferico","algodon");

            Console.WriteLine($"Auto 1: \n Cantidad puertas: {auto1.getCantPuertas()} \n Tapizado: {auto1.getTipoTapiceria()}\n");
            Console.WriteLine($"Auto 2: \n Cantidad puertas: {auto2.getCantPuertas()} \n Anio: {auto2.getAnio()} \n Climatizador: {auto2.getClimatizador()}\n");
            Console.WriteLine($"Auto 3: \n Cantidad puertas: {auto3.getCantPuertas()} \n Anio: {auto3.getAnio()} \n Climatizador: {auto3.getClimatizador()} \n Tapizado: {auto3.getTipoTapiceria()}\n");
            Console.ReadKey();
        }
    }
}
