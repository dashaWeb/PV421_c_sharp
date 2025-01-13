
// визначення типу делегату, делегат - тип (компілятор створить нам клас), який містить посилання на метод певної сигнатури
delegate void MsgDelegate(string message); // може посилатися на (static? non statuc) void - метод з параметром типу string

static class Greeting
{
    public static void Hello(string name) // цей метож підходить під наш делегат
    {
        Console.WriteLine($"Hello, {name}");
    }
    public static void Bye(string name) //  цей метож підходить під наш делегат
    {
        Console.WriteLine($"Bye, {name}");
    }
    public static void HowAreYou(string name)//  цей метож підходить під наш делегат
    {
        Console.WriteLine($"How are you, {name}");
    }
    public static void HowAreYou(string name, string surname)//  цей метож НЕ підходить під наш делегат
    {
        Console.WriteLine($"How are you, {name} {surname}");
    }
    public static void DrawLine(int len, ConsoleColor color)
    {
        Console.ForegroundColor= color;
        Console.WriteLine($"\n{new string('*',len)}");
        Console.ResetColor();
    }
}

delegate double CalcDelegate(double one, double two);
class Calculate
{
    public static double Add(double a, double b) => a + b;
    public static double Sub(double a, double b) => a - b;
    public double Mult(double a, double b) => a * b;

}
internal class Program
{
    private static void Main(string[] args)
    {
        Greeting.DrawLine(70, ConsoleColor.Red);
        Greeting.Hello("Ivan"); // явний виклик(Invoke) стат. методу

        Greeting.DrawLine(70, ConsoleColor.Green);
        MsgDelegate del = new MsgDelegate(Greeting.Hello);
        del.Invoke("Maria");
        del("Vitaliy");

        Console.WriteLine($"________Del references to method : {del.Method}");
        Console.WriteLine($"________Del target to object : {del.Target}");


        Greeting.DrawLine(70, ConsoleColor.Green);
        del = Greeting.HowAreYou;
        Console.WriteLine($"________Del references to method : {del.Method}");
        del("Sasha");


        MsgDelegate group = new MsgDelegate(Greeting.Hello) + Greeting.HowAreYou;
        group += Greeting.HowAreYou;
        group += Greeting.Bye;
        Greeting.DrawLine(70, ConsoleColor.Magenta);

        group("Olia");

        Greeting.DrawLine(70, ConsoleColor.Magenta);
        group -= Greeting.HowAreYou;
        group("Olia");

        Greeting.DrawLine(70, ConsoleColor.Magenta);

        Console.WriteLine("\t \t \t Calculate");
        CalcDelegate calc = Calculate.Add;
        Console.WriteLine($"Method :: {calc.Method}");
        Console.WriteLine($"Target :: {calc.Target}");
        Console.WriteLine($"Result :: {calc(2,3)}");

        Greeting.DrawLine(70, ConsoleColor.DarkBlue);
        calc += Calculate.Sub;
        Console.WriteLine($"Method :: {calc.Method}");
        Console.WriteLine($"Target :: {calc.Target}");
        Console.WriteLine($"Result :: {calc(2, 3)}");

        Greeting.DrawLine(70, ConsoleColor.Green);
        foreach (var item in calc.GetInvocationList())
        {
            Console.WriteLine($"Operation {item.Method.Name}  :: {item.DynamicInvoke(10,15)}");
        }

        Calculate calculate = new Calculate();
        calc = calculate.Mult;
        Console.WriteLine($"Method :: {calc.Method}");
        Console.WriteLine($"Target :: {calc.Target}");
        Console.WriteLine($"Result :: {calc(2, 3)}");

    }
}