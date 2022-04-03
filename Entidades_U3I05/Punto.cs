using System;

namespace Entidades_U3I05
{
    public class Punto
    {
        int x;
        int y;

        public Punto (int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int GetX()
        {
            return this.x;
        }

        public int GetY()
        {
            return this.y;
        }
    }
}
