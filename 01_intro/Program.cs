internal class Program
{
    static void TaskConsole()
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.CursorTop = 14;
        Console.CursorLeft = 20;
        Console.Title = "dhdhdh";
        Console.ResetColor();
        Console.Clear();
    }
    static void WriteLineWays()
    {
        int numb = 10;
        double d = 53.6;
        decimal money = 485.25658m;
        float f = 35.6f;

        System.String line = "Hello ";
        string str = "C# language популярна мова .NET";


        // way 1
        Console.WriteLine("Money :: " + money + " \t fvalue :: " + f);

        // way 2
        Console.WriteLine("float value :: {0}; \t {0} \t {0} \t\t SQRT = {1}", f, Math.Sqrt(f));

        // way 3
        Console.WriteLine($"money :: {money * 2,-20}; number ^ 2 = {Math.Pow(numb, 2)}");
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        //Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.WriteLine(str);
       
    }
    static void ReadNumbers()
    {
        /*string line = Console.ReadLine();
        Console.WriteLine(line);*/

        string numb = Console.ReadLine();
        int res = Convert.ToInt32(numb);
        res += 10;
        Console.WriteLine($"Result :: {res}");

        double dd = double.Parse(Console.ReadLine());
        dd++;
        Console.WriteLine($"Result :: {dd}");

        int result;
        if (int.TryParse(Console.ReadLine(), out result))
        {
            Console.WriteLine($"Result :: {result}");
        }
        else
        {
            Console.WriteLine("Error");
        }

    }
    private static void Main(string[] args)
    {
        //TaskConsole();
        //ReadChar();
        //WriteLineWays();
        //ReadNumbers();

        // ==, !=, >, <, >=, <=
        // && - and, || - or

        //int day = Convert.ToInt32(Console.ReadLine());
        /*if(day == 1) {
            Console.WriteLine("Monday");
        }
        else if (day == 2)
        {
            Console.WriteLine("Tuesaday");
        }
        else if (day == 3)
        {
            Console.WriteLine("Wednesday");
        }
        else
        {
            Console.WriteLine("Error");
        }*/
        /*switch (day)
        {
            case 1:
            case 4:
            case 5:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesaday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            default:
                Console.WriteLine("Error");
                break;
        }*/
        /*int i = 0;
        for (;;)
        {
            i++;
            Console.WriteLine(i + ". Hello");
            if (i == 5)
                break;
        }
        Console.WriteLine("End :: " + i);*/
        /*ConsoleKey key;
        while ((key = Console.ReadKey().Key) != ConsoleKey.Escape)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    Console.WriteLine("press LeftArrow");
                    break;
                case ConsoleKey.RightArrow:
                    Console.WriteLine("press RightArrow");
                    break;
                case ConsoleKey.UpArrow:
                    Console.WriteLine("press UpArrow");
                    break;
                case ConsoleKey.DownArrow:
                    Console.WriteLine("press DownArrow");
                    break;
                default:
                    break;
            }
        }*/
        /*int res;
        do
        {
            Console.Write("2 + 2 = ");
            res = int.Parse(Console.ReadLine());
        } while (res != 4);*/

        // +,-,*,/,%
        // ++,--
        // -
        Console.WriteLine(@"
            test\
                    next
                            \t");
       /* int a = 5;
        while (a) // Error
        {

        }*/
    }

    static void ReadChar()
    {
        Console.Write("Enter symbol :: ");
        char symbol = (char)Console.Read();
        Console.WriteLine("Symbol   :: \t" + symbol);
        Console.WriteLine("IsLetter :: \t" + char.IsLetter(symbol));
        Console.WriteLine("IsUpper  :: \t" + char.IsUpper(symbol));
        Console.WriteLine("IsDigit  :: \t" + char.IsDigit(symbol));
        Console.WriteLine("ToUpper  :: \t" + char.ToUpper(symbol));
    }
  
}
