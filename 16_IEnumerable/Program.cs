using _16_IEnumerable;

internal class IEnumerable_demo
{
    private static void Main(string[] args)
    {
        Shop shop = new Shop();
        Item apple = new Item() {Name ="Apple",Price = 30 };
        Item orange = new Item() {Name ="Orange",Price = 60 };
        Item blueberry = new Item() {Name ="Blueberry",Price = 40 };
        Item plum = new Item() {Name ="Plum",Price = 70};
        shop.AddItem(apple);
        shop.AddItem(orange);
        shop.AddItem(blueberry);
        shop.AddItem(plum);

        Console.WriteLine("\n--------------- IEnumerable getEnumerator() -------------" );
        foreach (var item in shop)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("\n--------------- IEnumerable GetReverse() -------------");
        foreach (var item in shop.GetReverse())
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("\n--------------- IEnumerable GetLimitProduct() -------------");
        foreach (var item in shop.GetLimitProduct(60))
        {
            Console.WriteLine(item);
        }

    }

}