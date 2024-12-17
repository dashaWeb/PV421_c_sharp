using _09_Overload__operators;
using System.Net.Mail;

internal class Program
{
    private static void Main(string[] args)
    {
        Fraction one = new Fraction(1, 2);
        Fraction two = new Fraction(2, 3);
        Console.WriteLine($"One :: {one}; \t Two :: {two}");
        Console.WriteLine($"Num :: {one[0]}; \t Denom :: {one[1]}");
        Console.WriteLine($"{one} + {two} = {one + two}");
        Console.WriteLine($"{one} == {two} = {one == two}");
        Console.WriteLine($"{one} != {two} = {one != two}");
        Console.WriteLine(one ? "True" : "False");
        one[0] = 0;
        Console.WriteLine(one ? "True" : "False");
        Console.WriteLine(one++);
        Console.WriteLine(one);
        Console.WriteLine(++one);
        //Console.WriteLine($"{two} ==> int() {(int)two}");
        Console.WriteLine($"{one} ==> int() {(int)one}");

        double value = two;
        value = new Fraction(1, 2);
        Console.WriteLine($"Result explicit ==> {(double)two}");
    }
}