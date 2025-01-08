using _14_Interface;

internal class Program
{
    private static void Main(string[] args)
    {
        Duck duck = new Duck() { Weight = 8 };
        Console.WriteLine(duck.Weight);
        duck.Fly();
        duck.Move();
        duck.Swim();
        Console.WriteLine();

        Console.WriteLine("---------------- Duck IFly ----------------");
        IFly fly = duck;
        fly.Fly();
        Console.WriteLine(fly.Speed);
        Console.WriteLine("---------------- Duck IMove ----------------");
        IMove move = duck;
        move.Move();
        Console.WriteLine(move.Speed);

        Console.WriteLine("---------------- Streamer Duck ----------------");
        StreamerDuck streamer = new StreamerDuck();
        streamer.Fly();

        Console.WriteLine("---------------- Array Ducks ----------------");

        IFly[] ducks = { duck, streamer };
        foreach (var item in ducks)
        {
            Console.WriteLine(item.Speed);
            item.Fly();
        }
    }
}