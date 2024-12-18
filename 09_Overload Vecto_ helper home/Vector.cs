using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Overload_Vecto__helper_home
{
    internal class Vector
    {
        double x, y;
        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return x;
                    case 1: return y;
                    default: return -1;
                }
            }
            set
            {
                switch (index)
                {
                    case 0: this.x = value; break;
                    case 1: this.y = value; break;
                }
            }
        }
    }
}
