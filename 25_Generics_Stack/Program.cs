using _25_Generics_Stack;

internal class Program
{
    private static void Main(string[] args)
    {
        /*object[] test = { 1, 2.5, "test", true }; // boxing
        foreach (object o in test)
        {
            //Console.WriteLine((int)o + 1); // unboxing
            if(o is int)
                Console.WriteLine((int)o + 1);
            if(o is double)
                Console.WriteLine((double)o + 1);
            *//*if(o is bool)
                Console.WriteLine((int)o + 1);*//*
        }*/
        MyStack<int> stack = new MyStack<int>(10);
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);

        while(stack.Count > 0)
        {
            Console.WriteLine(stack.Peek());
            stack.Pop();
        }
    }
}