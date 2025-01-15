using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Events_demo
{
    delegate void PositionDelegate(string description); // 1) визначили тип делегату під подію NewPosition
    internal class Company
    {
        public string Name { get; set; }

        public event PositionDelegate NewPosition; // 2 ) подія = делегат
        public void AddPosition(string description) // 3) бізнес логіка
        {
            NewPosition?.Invoke(description); // 4) виклие події
        }
    }
}
