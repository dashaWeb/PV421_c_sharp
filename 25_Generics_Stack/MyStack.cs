using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Generics_Stack
{
    internal class MyStack<T> : IStack<T>
    {
        T[] stack;
        const int Empty = -1;
        int top = Empty;
        public int Capacity => stack.Length;// reserve
        private bool Full() => top == Capacity - 1;

        public MyStack(int capacity = 5)
        {
            if(capacity < 0) capacity = 5;
            stack = new T[capacity];
        }
        public int Count => top + 1;

        public T Peek()
        {
            return stack[top]; // exception
        }

        public void Pop()
        {
            if (top != Empty)
                top--;
        }

        public void Push(T value)
        {
            if(Full())
                Array.Resize(ref stack, stack.Length + 5);
            stack[++top] = value;
        }
    }
}
