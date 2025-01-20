using System.Collections;

internal class Program
{
    static void DemoSortedList()
    {
        System.Collections.SortedList list = new System.Collections.SortedList()
        {
            {10,"ten"},
            { 5,"five"},
            {7,"seven" },
            {0, "false" },
            //{1.0, "one" } // exception
        };
        PrintList(list, "Print SortedList");

        list.Add(2, "two");
        list[7] = "SEVEN";
        list[1] = "one";
        PrintList(list, "Print SortedList");
        int key = 3;
        Console.WriteLine($"{key} ==> {list[key] ?? "NULL"}");
        if(!list.ContainsKey(key))
        {
            list.Add(key, "Something");
        }
        PrintList(list, "Print SortedList");

        key = 0;
        list.Remove(key);
        PrintList(list, "Print SortedList");
        int index = 0;
        if(index < list.Count)
        {
            list.RemoveAt(index);
        }
        PrintList(list, "Print SortedList");
    }
    static void SortedListGen()
    {
        SortedList<int, string> list = new SortedList<int, string>()
        {
            [1000] = "Olia",
            [555] = "Pavlo",
            [777] = "Dmytro"
        };
        PrintList(list);
        list.TryAdd(123, "Test");
        if(!list.ContainsKey(1000)) 
            list.Add(1000, "Ivan");
        PrintList(list);
        int id = 555;
        if(list.TryGetValue(id,out string name))
        {
            Console.WriteLine($"Get name by id {id} :: {name}");
        }
        list.RemoveAt(0);
        foreach (var item in list.Keys)
        {
            Console.WriteLine($"code : {item} - {list[item]}");
        }
    }
    static void PrintList(IDictionary list, string text = "")
    {

        Console.WriteLine("\n\t" + text);
        foreach (DictionaryEntry item in list)
        {
            Console.WriteLine($"{item.Key,-10} {item.Value}");
        }
    }
    private static void Main(string[] args)
    {
        //DemoSortedList();
        SortedListGen();
    }
}