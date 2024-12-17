internal class Program
{
    class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
    }
    private static void Main(string[] args)
    {
        string str = null;
        //int value = null;
        Console.WriteLine(default(string) == null);
        Console.WriteLine(default(int[]) == null);
        Console.WriteLine(default(int));
        Console.WriteLine(default(bool));
        //Console.WriteLine(value);
        //str = "Lorem ipsum";
        /*if(str == null)
        {
            Console.WriteLine("Default text");
        }
        else {
            Console.WriteLine(str);
        }*/
        Console.WriteLine();
        // Унарний оператор
        // ++i;
        // !true
        // -i
        //Бінарний оператор
        // a + b + c
        // a == b
        //Тернарний
        // a ? b : c
        str = "Lorem ipsum";
        Console.WriteLine(str != null ? str : "Default text");
        // ?? 
        str = null;
        Console.WriteLine(str??"Default text");

        //Person person= new Person() { Name = null};
        Person person= new Person() { Name = "Denis"};


        // ?
        //Person person = null;
        Console.WriteLine(person?.Name ?? "NoneName");
        str = "Lorem ipsum";
        Console.WriteLine(str?.Length ?? -1);
        Console.WriteLine(str?.Replace('m','@') ?? "Error");

        Nullable<int> value = null;
        Console.WriteLine(value.GetValueOrDefault());
        int?number = null;

        int[] arr = null;
        Console.WriteLine(arr?[0] ?? -1);

        arr ??= new int[6] { 1, 2, 3, 4, 5, 6 };
        Console.WriteLine(arr?[0] ?? -1);
    }
}