using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList list = new ArrayList() {41,2.5,"test",true,ConsoleColor.Red};

        Console.WriteLine($"Capacity :: {list.Capacity}");
        Console.WriteLine($"Count    :: {list.Count}");
        PrintList(list, "Print ArrayList");

        list.Add("lorem");
        list.AddRange(new int[] { 1, 2, 3, 4, 5, 6 });
        Console.WriteLine($"Capacity :: {list.Capacity}");
        Console.WriteLine($"Count    :: {list.Count}");
        PrintList(list, "Print ArrayList after add");

        list.Remove("test");
        list.RemoveAt(0);
        PrintList(list, "Print ArrayList after remove");
        list.RemoveRange(2, 2);
        PrintList(list, "Print ArrayList after remove");

        list.Insert(2, "orange");
        PrintList(list, "Print ArrayList after insert");
        list.InsertRange(5, new string[] { "C#", "C++", "Python", "Java", "JavaScript" });
        Console.WriteLine($"Capacity :: {list.Capacity}");
        Console.WriteLine($"Count    :: {list.Count}");
        PrintList(list, "Print ArrayList after insert");
        list.TrimToSize();
        Console.WriteLine($"Capacity :: {list.Capacity}");
        Console.WriteLine($"Count    :: {list.Count}");

        list.Clear();
        Console.WriteLine($"Capacity :: {list.Capacity}");
        Console.WriteLine($"Count    :: {list.Count}");

        Random rnd = new Random();
        for (int i = 0; i < 5; i++)
        {
            list.Add((char)rnd.Next(65, 91));
        }
        PrintList(list, "Print ArrayList char");
        list.Sort();
        
        PrintList(list, "Print ArrayList char sort");

        Console.Clear();
        List<string> color = new List<string>()
        {
            "red","green","purple","yellow","Gold","magenta"
        };
        PrintList(color, "Print List");

        color.InsertRange(4, new string[] { "cyan", "pink", "brown" });
        PrintList(color, "Print List after insert");

        /*color.RemoveAll(x => x.Contains('o'));
        PrintList(color, "Print List after insert");*/

        color.Sort();
        PrintList(color, "Print List after sort");

        color.Sort((s1,s2) => s1.Length.CompareTo(s2.Length));
        PrintList(color, "Print List after sort by length");
    }

    static void PrintList(IEnumerable list, string text = "")
    {
        Console.WriteLine(text);
        
        foreach (var item in list)
        {
            Console.Write($"{item,10}");
        }
        Console.WriteLine();
    }
}