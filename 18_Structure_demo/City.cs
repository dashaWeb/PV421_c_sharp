using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Structure_demo
{
    struct City :IComparable, IComparable<City>
    {
        const int DefaultPopulation = 10_000;
        const int MaxPopulation = 100_000_000;
        private int population;
        public int Population { 
            get => population; 
            set => population = value <= MaxPopulation ? value : MaxPopulation; }

        public string Name { get; set; } //= "NoName"; Error

        public City(string name, int population = DefaultPopulation)
        {
            Name = name;
            Population = population;
        }
        public override string ToString()
        {
            return $"Name :: {Name,-10} Population :: {Population,-15}";
        }

        public int CompareTo(object? obj)
        {
            if (!(obj is City))
                throw new ArgumentException("obj not City");
            City city = (City)obj;
            //return this.population - city.population;
            return this.population.CompareTo(city.population);
        }

        public int CompareTo(City other)
        {
           return this.population.CompareTo(other.population);
        }
    }
    struct SortByName : IComparer<City>
    {
        public int Compare(City x, City y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }

    struct SortByNameDesc : IComparer<City>
    {
        public int Compare(City x, City y)
        {
            return -x.Name.CompareTo(y.Name);
        }
    }
}
