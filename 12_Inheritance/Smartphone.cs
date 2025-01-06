using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Inheritance
{
    internal class Smartphone : Device
    {
        public bool HasBattery { get; set; } = true;
        public Smartphone(string brand = "Nobrand", int year = 2000, bool battery = true)
        : base(brand, year)
        {
            HasBattery = battery;
        }
        public override void Print()
        {
            Console.WriteLine($"{this.GetType().Name,-10} Brand :: {brand,-10} Year :: {Year,-10} Weigth :: {Weight,-10} Price :: {Price,-10} Battery :: {HasBattery,-10}");
        }
        public void Call()
        {
            Console.WriteLine($"\n{new string('#', 50)}\n\t Method Call work \n{new string('#', 50)}");
        }
    }
}
