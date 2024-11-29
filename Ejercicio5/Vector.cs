using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    public class Vector
    {
        private int x;
        private int y;
        private int z;

        public Vector(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public int getX() { return x; }
        public int getY() { return y; }
        public int getZ() { return z; }

        public string SumarVector(Vector vector)
        {
            int totalX = 0;
            int totalY = 0;
            int totalZ = 0;
            totalX = this.x + vector.x;
            totalY = this.y + vector.y;
            totalZ = this.z + vector.z;
            return $"La suma de los vectores es (x={totalX}, y={totalY}, z={totalZ})";
        }

        public string RestarVector(Vector vector)
        {
            int totalX = 0;
            int totalY = 0;
            int totalZ = 0;
            totalX = this.x - vector.x;
            totalY = this.y - vector.y;
            totalZ = this.z - vector.z;
            return $"La resta de los vectores es (x={totalX}, y={totalY}, z={totalZ})";
        }

        public string CalcularDistancia(Vector vector)
        {
            double distancia = 0;
            distancia = Math.Sqrt(Math.Pow(this.x - vector.x, 2) + Math.Pow(this.y - vector.y, 2) + Math.Pow(this.z - vector.z, 2));
            return $"La distancia entre los dos vectores es: {distancia}";
        }
    }
}
