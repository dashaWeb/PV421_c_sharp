using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Overload__operators
{
    partial class Fraction
    {
        private int num;
        private int denom;
        public int Num { get => num; set => num = value; }
        public int Denom { get => denom; set => denom = value != 0 ? value : -1; }
        public override string ToString()
        {
            return $"{num}/{denom}";
        }
        public Fraction(int num, int denom)
        {
            Num = num;
            Denom = denom;
        }

        public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return num;
                    case 1: return denom;
                    default: return -1;
                }
            }
            set 
            {
                switch (index)
                {
                    case 0: num = value; break;
                    case 1: Denom = value; break;
                    default:
                        break;
                }
            }
        }
    }
}
