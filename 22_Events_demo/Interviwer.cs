using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Events_demo
{
    internal class Interviwer
    {
        public string Name { get; set; }

        // метод під делегат PositionDelegate
        public void Dosomething(string desc)
        {
            Console.WriteLine($"Interviwer {Name} notified about {desc}");
        }
    }
}
