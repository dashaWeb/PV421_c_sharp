using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine($"Current path \n {Directory.GetCurrentDirectory()}");
        Directory.CreateDirectory("A");
        Directory.SetCurrentDirectory("A");
        Console.WriteLine($"Current path \n {Directory.GetCurrentDirectory()}");

        Directory.CreateDirectory("A1");
        Directory.CreateDirectory("A2");

        File.WriteAllText("a.txt", "File a.txt content");
        File.WriteAllText("b.txt", "File b.txt content");

        File.WriteAllText("A1/a1.txt", "File a1.txt content");
        File.WriteAllText("A2/a2.txt", "File a2.txt content");

        //var files = Directory.GetFiles(".");
        var files = Directory.GetFiles(".","*.*", SearchOption.AllDirectories);
        foreach (var file in files)
        {
            Console.WriteLine($"{Path.GetFileName(file)} in folder {Path.GetDirectoryName(file)}");
        }

        var dirs = Directory.GetDirectories(".");
        Console.WriteLine("\n\nList folders from folder A");
        foreach (var d in dirs)
        {
            Console.WriteLine(d);
            Console.WriteLine(Path.GetFileName(d));
        }

        Console.OutputEncoding = Encoding.Unicode;
        string path = @"C:\Users\konopelko\Downloads";
        var entries = Directory.GetFileSystemEntries(path);
        Console.WriteLine($"\n\n ----------- {path}");
        foreach (var e in entries)
        {
            FileInfo fi = new FileInfo(e);
            string info = "<DIR>";
            if(!fi.Attributes.HasFlag(FileAttributes.Directory))
                info = fi.Length.ToString();
            Console.WriteLine($"{fi.CreationTime,-22} {fi.Name,-30} {info,-15}");
        }

        path = "B";
        DirectoryInfo di = new DirectoryInfo(path);
        if(!di.Exists)
            di.Create();
        Console.WriteLine($"Atrributes of 'B' {di.Attributes}");
        File.WriteAllText("B/b1.txt", "Hello from b1.txt");
        File.WriteAllText("B/b2.txt", "Hello from b2.txt");

        var file_info = di.GetFiles();
        foreach (var item in file_info)
        {
            Console.WriteLine($"{item.Name} :: {item.Length}");
        }

        Directory.Delete(".",true);
    }
}