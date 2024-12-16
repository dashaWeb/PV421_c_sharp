using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Class__intro
{
    // public - відкритий для інших збірок
    // internal - закритий для інших збірок, видимий для своєї збірки
    internal class Character // неявне успадкувався від супертипу Object
    {
        private string name = "NoName";
        private uint hp = 100;
        public string Name
        {
            /*get
            {
                return name;
            }*/
            get => name;
            set
            {
                // value - значення яке будемл присвоювати
                /*if(value.Length == 0)
                {
                    name = "Test";
                }
                else
                {
                    name = value;
                }*/
                if(!String.IsNullOrWhiteSpace(value)) // не порожній рядок, не null, не "   " or \t, \n
                    name = value;
            }
        }
        public uint Damage { get; set; } // авто властивість, компілятор створить поле
        public Character(string name, uint hp, uint damage)
        {
            //this.name = name;
            Name = name;
            this.hp = hp;
            Damage = damage;
        }
        public Character(string name = "None")
            :this(name, 100,5)
        {}
        public void Print()
        {
            Console.WriteLine($"Character name   :: {Name}");
            Console.WriteLine($"Character hp     :: {hp}");
            Console.WriteLine($"Character damage :: {Damage}");
        }
        public uint KPD { get => Damage * hp;}
        public override string ToString()
        {
            return $"Name :: {Name,-10} HP :: {hp,-10} Damage :: {Damage,-10} KPD :: {KPD}";
        }
        public uint Hp { get; set; }
    }
}
