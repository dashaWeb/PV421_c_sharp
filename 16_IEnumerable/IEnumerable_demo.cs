/*internal class IEnumerable_demo
{
    private static void Main(string[] args)
    {
        // Enumerable - це те що ми перелічуємо
        // Enumerator - це те чим проходимо

        int[] arr = { 4, 44, 5, 8, 10, 12, 15 };
        var enArr = arr.GetEnumerator();
        while (enArr.MoveNext())
        {
            Console.Write($"{enArr.Current,-7}");
        };
        Console.WriteLine();
    }

}*/