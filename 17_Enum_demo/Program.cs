enum Color : byte
{
    Red = 4, Blue = 1, White = 14, Black = 0
}// default - int
internal class Program
{
    private static void Main(string[] args)
    {
        Color color = Color.Red;
        Console.WriteLine($"{color/*.toString()*/} = {(byte)color}");

        Console.WriteLine("Input :: Red, Blue, White, Black ");

        /*color =(Color)Enum.Parse(typeof(Color), Console.ReadLine()!, true);
        Console.WriteLine($"{color*//*.toString()*//*} = {(byte)color}");*/

        /*if(Enum.TryParse<Color>(Console.ReadLine()!,true,out color))
        {
            Console.WriteLine($"{color*//*.toString()*//*} = {(byte)color}");
        }
        else
        {
            Console.WriteLine("Color not found");
        }*/
        Console.WriteLine("\n ---------------- Enum.GetNames() -----------");
        //string[] names = Enum.GetNames( typeof( Color ) );
        string[] names = Enum.GetNames(typeof(ConsoleColor));
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
        /*ConsoleColor cl;
        while ((Console.ReadKey()).Key != ConsoleKey.Escape)
        {
            if (Enum.TryParse<ConsoleColor>(Console.ReadLine()!, true, out cl))
            {
                Console.ForegroundColor = cl;
                Console.WriteLine(cl);
                Console.ResetColor();
            }
        }*/
        Console.WriteLine("\n ---------------- Enum.GetValues() -----------");
        //Color[] res = (Color[])Enum.GetValues(typeof(Color));
        //foreach (var item in res)
        //{
        //    Console.WriteLine($"{item} = {(byte)item}");
        //}

        ConsoleColor[] res = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));
        foreach (var item in res)
        {
            Console.ForegroundColor = item;
            Console.WriteLine(item);
            Console.ResetColor();
        }
    }
}