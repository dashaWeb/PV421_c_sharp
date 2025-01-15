internal class Program
{
    private static void Main(string[] args)
    {
        Action act = () => { Console.WriteLine("Hello from std delegates(Action)"); };
        act += Hello;
        act();

        Action<string, int> act2= (str, numb) => { Console.WriteLine($"#{numb} :: {str}"); };
        act2("test", 100);
        Console.WriteLine();

        Func<int, int, double> func = (one, two) => (one + two) / 2.0;
        Console.WriteLine($"Func avg --> {func(10,11)}");

        Predicate<string> pred = a => Char.IsUpper(a[0]);
        string wordA = "Program";
        string wordB = "python";
        Console.WriteLine($"Has first upper letter :: {pred(wordA)}"); // True
        Console.WriteLine($"Has first upper letter :: {pred(wordB)}"); // False

        Comparison<string> cmp = (s1,s2) => s1.Length.CompareTo(s2.Length);
        Console.WriteLine(cmp(wordA,wordB)); // 1
        Console.WriteLine(cmp(wordB,wordA));//-1
    }
    static void Hello()
    {
        Console.WriteLine("Hello Action");
    }
    static bool iSFib(int number)
    {
        int a = 0, b = 1, c = 0;
        while (c < number)
        {
            c = a + b;
            a = b;
            b = c;
        }
        return c == number;
    }
}