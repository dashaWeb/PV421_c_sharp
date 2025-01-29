using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_LINQ_to_object_collection
{
    public class Book
    {
        public enum CategoryBook {Cooking = 1, Children, NET, Web }
        public string Title { get; set; }
        public string Author { get; set; }
        public CategoryBook Category { get; set; }
        public ushort Year { get; set; }
        public float Price { get; set; }
        public override string ToString()
        {
            return $"{Author,-20}{Title,-30}{Category.ToString(),-10}{Year,-6}{Price}";
        }
    }
}
