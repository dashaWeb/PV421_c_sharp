internal class Program
{
    static void Print(int[,] arr)
    {
        /*for (int i = 0; i < arr.GetLength(0); i++) // проходить по рядках
        {
            for (int j = 0; j < arr.GetLength(1); j++) // проходить по колонках
            {
                Console.Write($"{arr[i,j], -20}");
            }
            Console.WriteLine();
        }*/
        foreach (var item in arr)
        {
            Console.Write($"{item,-20}");
        }
        Console.WriteLine();
    }
    static void Print(int[][] arr)
    {
        /* for (int i = 0; i < arr.Length; i++)
         {
             for (int j = 0; j < arr[i].Length; j++)
             {
                 Console.Write($"{arr[i][j], -20}");
             }
             Console.WriteLine();
         }*/
        foreach (int[] row in arr)
        {
            foreach (var item in row)
            {
                Console.Write($"{item,-20}");
            }
            Console.WriteLine();
        }
    }
    static void MathRows(int[][] arr)
    {
        foreach (int[] row in arr)
        {
            Console.WriteLine($"Sum :: {row.Sum()}");
            Console.WriteLine($"Min :: {row.Min()}");
            Console.WriteLine($"Max :: {row.Max()}");
            Console.WriteLine($"AVG :: {row.Average()}");
            Console.WriteLine();
        }
    }
    static void SwapRows(int[][] arr, int row1, int row2) 
    {
        if(row1 >= 0 && row2 >= 0 && row1 < arr.Length && row2< arr.Length)
        {
            int[] tmp = arr[row1];
            arr[row1] = arr[row2];
            arr[row2] = tmp;
        }
    }
    private static void Main(string[] args)
    {
        /*int[,] arr = new int[3,4] {
            {1,2,3,4 },
            {11,12,13,14}, 
            {111,222,333,444}
        };
        Console.WriteLine("Length :: " + arr.Length);
        Console.WriteLine("Length :: " + arr);
        Print(arr);
        Console.WriteLine();
        arr[0, 0] = 3;
        Print(arr);*/
        int[][] arr = new int[4][];
        arr[0] = new int[3] { 1, 2, 3 };
        arr[1] = new int[] { 1, 2, 3 ,4,5};
        arr[2] = new [] { 10, 20};
        arr[3] = new [] { 10, 20,30,40};
        Print(arr);
        MathRows(arr);
        for (int i = 0; i < arr.Length / 2; i++)
        {
            SwapRows(arr, i, arr.Length - 1 - i);
        }

        Console.WriteLine();

        Print(arr);
    }
}