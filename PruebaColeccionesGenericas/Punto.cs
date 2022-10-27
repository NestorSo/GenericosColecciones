using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaColeccionesGenericas
{
    internal class Punto:IComparable<Punto>
    {
        private int x;
        private int y;  

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int CompareTo(Punto? b)
        {
            double maga = Math.Sqrt(x*x+y*y);           
            double magb = Math.Sqrt(b.x*b.x+b.y*b.y);

            if (maga > magb)
                return 1;
            if (maga < magb) 
                return -1;
            return 0;
        }

        public override string ToString()
        {
            return string.Format("x={0},y={1}", x, y);
        }
    }
}
