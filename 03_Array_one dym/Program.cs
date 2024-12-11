
using System.Collections.Specialized;

internal class Program
{
    static void Print<T>(T[] arr, string prompt = "")
    {
        Console.Write(prompt);
        /*for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{arr[i],-10}");
        }*/

        foreach (var item in arr)
        {
            Console.Write($"{item,-10}");
        }

        Console.WriteLine();
    }
    static void Fill(int[] arr, int min = 0, int max = 50) // array - ref type
    {
        Random rnd = new Random();
        /*foreach (var item in arr) //error - read only
        {
            item = rnd.Next(min, max);
        }*/
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(min, max);
        }
    }
    static void PushBack(ref int[] arr, int value)
    {
        /*int[] tmp = new int[arr.Length + 1];
        *//*for (int i = 0; i < arr.Length; i++)
        {
            tmp[i] = arr[i];
        }*//*
        arr.CopyTo(tmp, 0);
        tmp[tmp.Length - 1] = value;
        arr = tmp;*/
        Array.Resize(ref arr, arr.Length + 1);
        arr[arr.Length - 1] = value;
    }
    private static void Main(string[] args)
    {
        int[] arr = new int[5] { 1,2,3,4,5};
        int[] arr2 = {10,20,30,40,50 };
        //int[] arr3; // null
        Print(arr,  "Print Array #1 :: ");
        Print(arr2, "Print Array #2 :: ");
        Console.Write("Enter number of elements :: ");
        int size = 10; //int.Parse(Console.ReadLine());
        int[] arr3 = new int[size];
        Fill(arr3,-10,10);

        Console.WriteLine();
        Print(arr3, "Print rand array       :: ");
        PushBack(ref arr3, 222);
        Print(arr3, "Print array after push :: ");
        int value = 222;/*int.Parse(Console.ReadLine());*/
        // бібліотека Linq - методи розширення для роботи з масивом
        if (arr3.Contains(value)) 
        {
            Console.WriteLine($"value {value} was found");
        }
        else
        {
            Console.WriteLine($"value {value} not found");
        }
        Console.WriteLine($"number of elements is positive :: {arr3.Count(IsPositive)}");
        int index = Array.IndexOf(arr3,value);
        if(index != -1)
        {
            Console.WriteLine($"Value {value} = index {index}");
            int lastIndex = Array.LastIndexOf(arr3,value);
            Console.WriteLine($"Value {value} = last index {lastIndex}");
        }
        Console.WriteLine();
        int firstPositive = Array.FindIndex(arr3, IsPositive);
        if (firstPositive != -1)
        {
            Console.WriteLine($"Value positive = index {firstPositive}");
            int lastPositive = Array.FindLastIndex(arr3, IsPositive);
            Console.WriteLine($"Value positive  = last index {lastPositive}");
        }
        // (formal params list) => {return ...;};
        index = Array.FindIndex(arr3, (int e) => { return e % 3 == 0; });
        Console.WriteLine($"position first number % 3  -->  {index}");
        int[] events = Array.FindAll(arr3, e => e % 2 == 0);
        Print(events, "Print even elements :: ");
        Console.WriteLine(Array.TrueForAll(arr3,IsPositive));
        Console.WriteLine(Array.Exists(arr3,IsPositive));

        Print(arr3, "\n\nPrint rand array       :: ");
        Array.Sort(arr3);
        Print(arr3, "Print rand array       :: ");
        Array.Reverse(arr3);
        Print(arr3, "Print rand array       :: ");
        Console.WriteLine(arr3.Sum());
        Console.WriteLine(arr3.Min());
        Console.WriteLine(arr3.Max());
        Console.WriteLine(arr3.Average());

        Console.WriteLine("\n\n");
        string[] colors = { "red", "yellow", "Gold", "purple", "aque" };
        Print(colors, "Print Colors :: ");
        Array.Sort(colors);
        Print(colors, "Print Colors ::  ");
        Array.Sort(colors, (s1,s2) => s1.Length.CompareTo(s2.Length));
        Print(colors, "Print Colors :: ");
    }
    static bool IsPositive(int a)
    {
        return a > 0;
    }
}