using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _32_XML_Serializer
{
    // 1) клас для серіалізації - public
    // 2) серіалізувати можна - public поля, властивості
    // 3) явний конструктор по замовчуванню
    public class Engine
    {
        public double Power { get; set; } // auto-props
        public Engine(double power)
        {
            Power = power;
        }
        public Engine()
            :this(1.0)
        {}
        public override string ToString()
        {
            return $"Engine power : {Power}";
        }

    }
    public class Car
    {
        //[XmlAttribute("id")]
        //[XmlIgnore]
        public int id;
        private string brand;
        public string Brand { get=>brand; set=> brand = value ?? "Nobrand"; }
        public Engine Engine { get; set; }
        public Car(int id, string brand, double power)
        {
            this.id = id;
            Brand = brand;
            Engine = new Engine(power);
        }
        public Car()
            :this(0,"Nobrand",1.0)
        {}
        public override string ToString()
        {
            return $"ID:{id}. Car brand : {Brand,-15} {Engine}";
        }
    }
}
