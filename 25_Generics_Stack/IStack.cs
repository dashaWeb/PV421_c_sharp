using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Generics_Stack
{
    internal interface IStack<T>
    {
        void Pop();
        void Push(T value);
        T Peek();
        int Count { get; }
    }
}
