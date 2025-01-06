using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Inheritance
{
    public abstract class Device
    {
        protected string brand;
        public string Brand { get=>brand; set=> brand = value ?? "Nobrand"; }
        private int year;
        public int Year { get => year;
            set => year = value <= DateTime.Today.Year && value > 0 ? value : 2000; }
        public Device(string brand = "NoBrand", int year = 2000)
        {
            Brand = brand;
            Year = year;
        }
        protected int Weight { get; set; }
        public int Price { get; set; }
        public abstract void Print();
    }
}
