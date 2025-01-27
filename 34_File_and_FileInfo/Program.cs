internal class Program
{
    private static void Main(string[] args)
    {
        string[] lines = { "Line 1", "Line 2" };
        string fname = "../../../my.txt";
        //File.SetAttributes(fname, FileAttributes.Archive);
        if(File.Exists(fname))
        {
            File.Delete(fname);
            Console.WriteLine($"File '{fname}' was deleted");
        }
        File.AppendAllLines(fname, lines);
        File.AppendAllText(fname, "Line 3\nLine 4");

        //Console.WriteLine($"Content of file '{fname}' \n{File.ReadAllText(fname)}");
        Console.WriteLine($"Content of file '{fname}' \n{String.Join<string>("\n", File.ReadAllLines(fname))}");

        string fname2 = "../../../copy_my.txt";
        //File.Copy(fname, fname2); //exception, якщо файл вже існує (fname2);
        File.Copy(fname, fname2, true); //дозвіл на перезапис у файл (fname2);
        Console.WriteLine($"\nContent of copy file '{fname2}' :: \n{File.ReadAllText(fname2)}");


        //FileStream fs = File.Create(fname2);
        StreamWriter sw = File.CreateText(fname);
        sw.WriteLine("Write something .... ");
        sw.Close();
        
        

        File.AppendAllText(fname, "New line");
        Console.WriteLine($"\nContent of file (after append '{fname}'\n{File.ReadAllText(fname)})");

        Console.WriteLine($"Creation time {File.GetCreationTime(fname)}");
        Console.WriteLine($"Last write time {File.GetLastWriteTime(fname)}");

        string fname3 = "../../../third.txt";
        FileInfo file= new FileInfo(fname3);
        Console.WriteLine($"\n\n Is Exists file '{fname3}' :: {file.Exists}");
        if(!file.Exists) {
            using (var tw = file.CreateText())
            {
                tw.WriteLine("It is third file");
            }
        }
        Console.WriteLine($"FullName      :: {file.FullName}");
        Console.WriteLine($"Name          :: {file.Name}");
        Console.WriteLine($"Directory     :: {file.Directory}");
        Console.WriteLine($"DirectoryName :: {Path.GetFileName(file.DirectoryName)}");
        Console.WriteLine($"Content of file '{fname3}' \n{File.ReadAllText(file.FullName)}");


        //file.MoveTo("./third.txt");
        //file.MoveTo("./third.txt",true);
        //file.MoveTo(Path.Combine(".",file.Name),true);
        Console.WriteLine($"Length     :: {file.Length}");
        Console.WriteLine($"Extension  :: {file.Extension}");
        Console.WriteLine($"Attributes :: {File.GetAttributes(fname)}");

        File.SetAttributes(fname, FileAttributes.Hidden);
        Console.WriteLine($"Attributes :: {File.GetAttributes(fname)}");

    }
}