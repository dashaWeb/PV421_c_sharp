
static class ExtensionInt
{
    public static uint CountDigit(this int number)
    {
        return (uint)Math.Abs(number).ToString().Length;
    }
}
static class ExtensionArray
{
    public static int SumPositiveElement(this int[] arr)
    {
        return Array.FindAll(arr, x => x > 0).Sum();
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        int value = -1245522458;
        Console.WriteLine(value.CountDigit());
        int[] arr = { 1, 2, 5, 8, -10, -20, -5, 10, -20 };
        Console.WriteLine($"Sum :: {arr.SumPositiveElement()}");
    }
}