using _18_Structure_demo;

internal class Program
{
    private static void Main(string[] args)
    {
        City city = new City();
        Console.WriteLine(city);

        City rivne = new City("Rivne",240_451);
        Console.WriteLine(rivne);

        City clone = rivne; // поверхневе копіювання

        Console.WriteLine();
        Console.WriteLine("Origin :: " + rivne);
        Console.WriteLine("Clone  :: " + clone);

        clone.Name = "Rivne-2";
        clone.Population++;
        Console.WriteLine();
        Console.WriteLine("Origin :: " + rivne);
        Console.WriteLine("Clone  :: " + clone);


        int value = 42, value2 = 123;

        int[] arr = { 4, -2, 8, 9, 6, 5, -4, 1, -2 };
        Console.WriteLine(String.Join<int>(", ",arr));
        Array.Sort(arr);
        Console.WriteLine(String.Join<int>(", ",arr));
        Console.WriteLine(value.CompareTo(value2)); // -1
        Console.WriteLine(value2.CompareTo(value)); // 1
        value = 123;
        Console.WriteLine(value2.CompareTo(value)); // 0


        City[] cities =
        {
            new City("Kyiv",2_952_000),
            new City("Poltava",272_572),
            new City("Lviv",710_606),
            rivne,

        };
        foreach (var item in cities)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        //Array.Sort(cities,(a,b) => a.Population.CompareTo(b.Population));
        Array.Sort(cities);
        foreach (var item in cities)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        SortByName cmp = new SortByName();
        Array.Sort(cities,cmp);
        foreach (var item in cities)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();


        Array.Sort(cities, new SortByNameDesc());
        foreach (var item in cities)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}