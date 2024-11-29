using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    /*
     Realice el código, para poder imprimir en pantalla el nombre de un alumno o el nombre y la edad, según se prefiera. 
     Para esto debe crear una clase alumno que contenga los constructores adecuados y al menos un método imprimirNombre y otro imprimirNombreEdad. 
     Puede agregar métodos getters y setters si lo prefiere.
    */
    public class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Carlitos",24);
            Alumno alumno2 = new Alumno("Pedro",21);

            alumno1.ImprimirNombre();
            Console.WriteLine("");
            alumno2.ImprimirNombreEdad();

            Console.ReadKey();
        }
    }
}
