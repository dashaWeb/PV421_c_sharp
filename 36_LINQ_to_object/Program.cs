internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = {1,-45,-8,6,3,5,10,-14,-12 };

        /*
        IEnumerable<>  res =  from item_name in collection
                              select item_name   
        */
        Print(arr, "Print array origin");

        IEnumerable<int> query = from numb in arr 
                                 select numb * -1; // відкладене завантаження
        
        //List<int> ints = query.ToList();// негайне завантаження
        Print(query, "Test Select");

        query = arr.Select(ConvertData);
        Print(query, "Test Method Select");
        query = arr.Select(delegate (int item) { return item * 2; });
        Print(query, "Test Method Select * 2");
        query = arr.Select(item => item / 2);
        Print(query, "Test Method Select / 2");

        // Where --> filter 

        query = from numb in arr
                where numb % 2 == 0
                select numb;
        Print(query, "Test Where (Only the even elements)");

        query = arr.Where(x => x % 2 != 0).Select(x=> (int)Math.Pow(x,2));
        Print(query, "Test Where (Only the odd elements)");

        string[] colors = {"red","pink","violet","purple","lime","gold","brown","black" };
        Print(colors, "Print colors ");
        var res = from c in colors
                  where c.Length == 4
                  select c;
        Print(res, "Print color length 4");
        res = colors.Where(c => c.Length == 4);     
        Print(res, "Print color length 4");
        Console.WriteLine($"Color with max length :: {colors.Max(x => x.Length)}");
        res = from c in colors
              where c.Contains('a')
              select c;
        Print(res, "Print colors with letter a");
    }
    static void Print<T>(IEnumerable<T> query, string text = "")
    {
        Console.WriteLine($"{(text?.Length == 0 ? "" : "\n\t")} {text}");
        foreach (var item in query)
        {
            Console.Write($"{item,-7}");
        }
        Console.WriteLine();
    }
    static int ConvertData(int value)
    {
        return (int)Math.Pow(value, 2);
    }
}