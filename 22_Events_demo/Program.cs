using _22_Events_demo;

internal class Program
{
    private static void Main(string[] args)
    {
        Company softServe = new Company() { Name = "SoftServe" };
        Company honeyComb = new Company() { Name = "Honey Comb" };

        Interviwer maria = new Interviwer() { Name = "Maria" };
        Interviwer ivan = new Interviwer() { Name = "Ivan" };

        softServe.NewPosition += maria.Dosomething;
        softServe.NewPosition += ivan.Dosomething;

        honeyComb.NewPosition+= maria.Dosomething;
        honeyComb.NewPosition += ivan.Dosomething;

        softServe.AddPosition("Intern C++");
        Console.WriteLine();
        Console.ReadKey();

        honeyComb.AddPosition("Junior .NET");

        Console.WriteLine();
        Console.ReadKey();

        honeyComb.NewPosition -= maria.Dosomething;
        honeyComb.AddPosition("Middle Frontend");
    }

   
}