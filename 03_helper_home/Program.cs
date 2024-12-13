internal class Program
{
    static void Swap(ref int x, ref int y) // 
    {
        var tmp = x;
        x = y;
        y = tmp;
    }
    static void Print<T>(T[] arr, string prompt = "")
    {
        Console.Write(prompt);
        foreach (var item in arr)
        {
            Console.Write($"{item,-10}");
        }
        Console.WriteLine();
    }
    static void Fill(int[] arr, int min = 0, int max = 50) // array - ref type
    {
        Random rnd = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(min, max);
        }
    }

    static void SwapArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i+=2)
        {
            Swap(ref arr[i], ref arr[i + 1]);
        }
    }
    private static void Main(string[] args)
    {
        int[] arr = new int[10];
        Fill(arr);
        Print(arr, "Print Array :: ");
        SwapArray(arr);
        Print(arr, "Print Array :: ");
    }
}