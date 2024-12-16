using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Static_class_fields_methods
{
    enum Position
    {
        None, Manager = 1, QA, Developer, Economist, Director
    }
    internal class Employee
    {
        private static int lastId; 
        public readonly int ID = ++lastId; // readonly поле тільки для читання, встановлюється 1 раз (в конструкторі або тут )
        public string Name { get; set; } = "NoName";
        public DateTime Birth { get; set; }
        public Position Position { get; set; }

        //public static  int LastId => lastId;
        public static  int LastId { get => lastId; }
        public static bool SamePosition(Employee em1, Employee em2) => em1.Position == em2.Position;
        static Employee() // без параметрів спрацює до першого використання класу(створення обєкту, виклик статичного методу чи властивості)
        {
            Console.WriteLine("\t\t Static ctor done!");
            lastId = new Random().Next(1, 10) * 1000;
        }
        public override string ToString() => $"ID :: {ID,-5} Name :: {Name,-10} Birth :: {Birth.ToShortDateString(),-15} Position :: {Position}";
        public int Age => (int)((DateTime.Today - Birth).TotalDays / 365.25);
    }
}
