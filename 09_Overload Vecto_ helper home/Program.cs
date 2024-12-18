
using _09_Overload_Vecto__helper_home;

internal class Program
{
    private static void Main(string[] args)
    {
        Vector vector = new Vector(1, 2);
        Console.WriteLine($"x - {vector[0],-10} y - {vector[1]}");
        vector[0] = 11;
        vector[1] = 12;
        Console.WriteLine($"x - {vector[0],-10} y - {vector[1]}");
    }
}