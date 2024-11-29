using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Alumno
    {
        private string nombre;
        private int edad;

        public Alumno(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        //Nombre
        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        //Edad
        public int getEdad()
        {
            return edad;
        }      
        public void setEdad(int edad)
        {
            this.edad = edad;
        }

        public void ImprimirNombre()
        {
            Console.WriteLine($"Nombre:{nombre}");
        }

        public void ImprimirNombreEdad()
        {
            Console.WriteLine($"Nombre:{nombre}");
            Console.WriteLine($"Edad:{edad}");
        }
    }
}
