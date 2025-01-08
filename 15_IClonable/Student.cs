using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_IClonable
{
    internal class Student :ICloneable
    {
        public string Name { get; set; }
        private int[] marks;
        public Student(string name = "Noname", int numbMarks = 5)
        {
            Name = name;
            marks = new int[numbMarks];
        }
        public Student(string name, params int[] arr)
        {
            Name = name;
            marks = (int[]) arr.Clone();
        }
        public override string ToString()
        {
            return $"Name :: {Name,-10} Marks :: {String.Join<int>(", ",marks)}";
        }

        public object Clone()
        {
            return new Student(Name,marks);
        }

        public int this[int index]
        {
            get => marks[index]; 
            set => marks[index] = value >= 0 && value <= 12?
                value:
                throw new ArgumentOutOfRangeException("Bad value");
        }
    }
}
