using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, string> dic = new Dictionary<string, string>()
        {
            ["Hello"] = "привіт",
            ["bye"] = "бувай",
            ["program"] = "програма",
            ["developer"] = "програміст, розробник",
        };
        Console.OutputEncoding = Encoding.UTF8; 
        foreach (var item in dic)
        {
            Console.WriteLine($"{item.Key,-10} {item.Value}");
        }
        //dic.TryGetValue

        SortedDictionary<string,string> sortDic = new SortedDictionary<string,string>(dic);
        Console.WriteLine("Sorted");
        foreach (var item in sortDic)
        {
            Console.WriteLine($"{item.Key,-10} {item.Value}");
        }
        
    }
}