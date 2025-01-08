using _15_IClonable;

internal class Program
{
    private static void Main(string[] args)
    {
        Student student = new Student("Sasha",10,12,11,4,8,5,3,2,7);
        Console.WriteLine($"Origin :: {student} \n");

        Student clone = (student.Clone() as Student)!;
        Console.WriteLine($"Origin :: {student}");
        Console.WriteLine($"Clone  :: {clone} \n");

        clone.Name = "Olia";
        clone[0] = 2; 
        clone[1] = 3;

        Console.WriteLine($"Origin :: {student}");
        Console.WriteLine($"Clone  :: {clone} \n");
    }
}