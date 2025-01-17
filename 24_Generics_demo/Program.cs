class Person:IComparable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public int CompareTo(Person? other)
    {
        return this.Age.CompareTo(other.Age);
    }
    virtual public void Busy()
    {
        Console.WriteLine($"Person {Name} is busy .....");
    }
    public override string ToString()
    {
        return $"Name :: {Name,-10} Age :: {Age}";
    }
}
class Employee:Person
{
    public override void Busy()
    {
        Console.WriteLine($"Person {Name} is working"); 
    }
}
class Student { }
internal class Program
{
    static T Max <T>(T one, T two) where T : IComparable<T>
    {
        return one.CompareTo(two) > 0 ? one : two;
    }
    static void CheckBusy<T>(T person) where T : Person
    {
        person.Busy();
    }
    private static void Main(string[] args)
    {
        int a = 10, b = 15;
        Console.WriteLine($"Max {a}, {b} = {Max(a,b)}");
        string one = "book", two = ".net";
        Console.WriteLine($"Max {one}, {two} = {Max(one,two)}");

        Person p1 = new Person() { Name = "Oleg", Age = 20 };
        Person p2 = new Person() { Name ="Ivanna", Age=30 };
        Console.WriteLine($"Max {p1}, {p2} ---> {Max(p1,p2)}");

        //Student s1 = new Student();
        /*Student s2 = new Student();
        Console.WriteLine($"Max {s1}, {s2} ---> {Max(s1,s2)}");*/

        CheckBusy(p1);
        //CheckBusy(s1);
    }
}