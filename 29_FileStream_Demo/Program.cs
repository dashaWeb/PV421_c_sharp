using System.Text;

internal class Program
{
    static void WriteAndReadBytes()
    {
        using (FileStream fs = new FileStream("../../../bytes.dat", FileMode.OpenOrCreate))
        {
            byte byteValue = 65; // 41 A
            byte[] bytes = { 10, 11, 12, 13, 14, 15 };
            fs.WriteByte(byteValue);
            fs.Write(bytes, 0, bytes.Length);


            //fs.Position = 0;
            fs.Seek(0, SeekOrigin.Begin);
            //fs.Seek(-2, SeekOrigin.End);
            Console.WriteLine($"File size in bytes :: {fs.Length}");
            byte[] result = new byte[fs.Length];
            fs.Read(result, 0, result.Length);
            Console.WriteLine($"Result array :: {String.Join<byte>('\t', result)}");
        }
        /*fs.Close();
        fs.Dispose();*/
    }

    static void WriteInt(int value, string path)
    {
        using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
        {
            byte[] bytes = BitConverter.GetBytes(value);
            fs.Write(bytes, 0, bytes.Length);
        }
    }

    static int ReadInt(string path)
    {
        int value;
        using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            byte[] result = new byte[sizeof(int)];
            fs.Read(result, 0, result.Length);

            value = BitConverter.ToInt32(result, 0);
        }
        return value;
    }
    static void WriteStr(string value, string path)
    {
        /*byte[] bytes = Encoding.Unicode.GetBytes(value);
        using(FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
        {
            fs.Write(bytes,0, bytes.Length);
        }*/

        byte[] bytes = Encoding.Unicode.GetBytes(value);
        using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
        {
            fs.WriteByte((byte)bytes.Length);
            fs.Write(bytes, 0, bytes.Length);
        }
    }

    static string ReadStr(string path)
    {
        string value = String.Empty;
        /*using(FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            byte[] result = new byte[fs.Length];
            fs.Read(result, 0, result.Length);

            value = Encoding.Unicode.GetString(result);
        }*/

        using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            byte[] result = new byte[fs.ReadByte()];
            fs.Read(result, 0, result.Length);

            value = Encoding.Unicode.GetString(result);
        }

        return value;
    }

    static void WriteIntFS(int value, FileStream fs)
    {
        byte[] bytes = BitConverter.GetBytes(value);
        fs.Write(bytes,0,bytes.Length);
    }
    private static void Main(string[] args)
    {
        string fnumber = "../../../number.dat";
        //WriteInt(-45124,fnumber);
        Console.WriteLine($"Read file int :: {ReadInt(fnumber)}");
        string fstr = "../../../string.dat";
        //WriteStr("Hello", fstr);
        Console.WriteLine($"Read file string :: {ReadStr(fstr)}");

        using(FileStream fs = new FileStream(fnumber,FileMode.Create, FileAccess.Write))
        {
            int[] arr = { 10, 12, 14, 16, 18 };
            foreach (var item in arr)
            {
                WriteIntFS(item, fs);
            }
        }
    }
}