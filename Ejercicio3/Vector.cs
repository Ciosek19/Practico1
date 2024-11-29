using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
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
    }
}
