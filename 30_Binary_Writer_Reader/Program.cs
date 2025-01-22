using System.Reflection.Metadata;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string fname = "../../../data.dat";

        /*string line = "Test - line Тестовий рядок";
        double valueD = 258.32;
        int valueI = -542145;
        int[] arr = { 65, 66, 67, 68, 69 };


        using (BinaryWriter bw = new BinaryWriter(new FileStream(fname, FileMode.Create)))
        {
            bw.Write(line);
            bw.Write(valueD);
            bw.Write(valueI);

            bw.Write(arr.Length);

            foreach (var item in arr)
            {
                bw.Write(item);
            }
        }*/
        Console.OutputEncoding = Encoding.UTF8;
        using (BinaryReader br = new BinaryReader(new FileStream(fname, FileMode.Open)))
        {
            string line = br.ReadString();
            Console.WriteLine($"Read str    :: {line}");
            Console.WriteLine($"Read double :: {br.ReadDouble()}");
            Console.WriteLine($"Read int    :: {br.ReadInt32()}");

            Console.Write("\tRecovered array :: ");

            int[] res = new int[br.ReadInt32()];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = br.ReadInt32();
            }

            Console.WriteLine($"Result :: {String.Join<int>('\t', res)}");
        }
    }
}