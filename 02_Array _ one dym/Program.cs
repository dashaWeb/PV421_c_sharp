internal class Program
{
    static void BadSwap(int x, int y) // x, y - value type, прийшла копія значення
    {
        var tmp = x; 
        x = y; 
        y = tmp;
    }
    // ref, out - передача параметрів за посиланням
    // ref = фактичний параметр який МАЄ БУТИ ПРОІНІЦІАЛІЗОВАНИЙ !!! 
    // out = фактичний параметр який МОЖЕ БУТИ НЕ ПРОІНІЦІАЛІЗОВАНИЙ !!! параметр для збереження результату
    static void Swap(ref int x, ref int y) // 
    {
        var tmp = x;
        x = y;
        y = tmp;
    }
    static void SumTwo(int a, int b, out int res)
    {
        res = a + b;
    }
    private static void Main(string[] args)
    {
        // value type (int, double,float, long, char, bool, enum, struct) -> Stack
        // reference type (class, interface, string, BuilderString, delegate, array) -> Heap

        int a = 5, b = 10;
        Console.WriteLine($"a = {a,-10} b = {b}");
        //BadSwap(a, b);
        Swap(ref a, ref b);
        Console.WriteLine($"a = {a,-10} b = {b}");
        int res;
        SumTwo(a,b, out res);
        Console.WriteLine(res);
    }
}