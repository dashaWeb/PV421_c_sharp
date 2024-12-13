using System.Text;

internal class Program
{
    /*static int sum(int a, int b)
    {
        return a + b;
    }
    static int sum(int a, int b, int c)
    {
        return a + b + c;
    }*/
    static int sum(string text ,params int[] arr)
    {
        return arr.Sum();
    }
    private static void Main(string[] args)
    {
        string text = "C#  world C# !!!!!";
        //text[0] = char.ToUpper(text[0]);
        char[] chars = text.ToCharArray();
        chars[0] = char.ToUpper(chars[0]);
        Console.WriteLine(chars);

        text = new string(chars);
        Console.WriteLine(text);

        Console.WriteLine("Contains :: " + text.Contains("C#"));
        Console.WriteLine("StartsWith :: " + text.StartsWith("C#"));
        Console.WriteLine("EndsWith :: " + text.EndsWith("C#"));

        var index = text.IndexOf("C#"); // -1 not found
        Console.WriteLine($"IndexOf :: {index}");
        index = text.IndexOfAny("abcd".ToCharArray());
        Console.WriteLine($"IndexOfAny :: {index}");

        string one = "Apple", two = "Apricot";
        Console.WriteLine($"CompareTo :: {one.CompareTo(two)}");
        two = "apple";
        Console.WriteLine($"CompareTo :: {one.CompareTo(two)}");
        Console.WriteLine($"CompareTo :: {String.CompareOrdinal(one,two)}");
        Console.WriteLine($"CompareTo :: {String.Compare(one,two,true)}");

        string numb = "1,2,3,4,5,6,7,8,9,10";
        string[] numbers =  numb.Split(',');

        string[] colors = { "red", "blue", "yellow" };
        Console.WriteLine(String.Join(" --- ",colors));

        /*StringBuilder text = new StringBuilder("hello world");
        Console.WriteLine(text);
        text[0] = char.ToUpper(text[0]);
        Console.WriteLine(text.Capacity);
        text.AppendLine(" Test Append line");
        text.Append(" !!! C# C# ");
        Console.WriteLine(text);
        text.Insert(0, "C# ");
        Console.WriteLine(text);
        text.Remove(5, 10);
        Console.WriteLine(text);
        text.Replace("C#", "JS");
        Console.WriteLine(text);
        Console.WriteLine(text.Capacity);*/


        Console.WriteLine($"Sum :: {sum("sss",3,5,8,6,5,8,5,4,7)}");


    }
}