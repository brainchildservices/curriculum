using System;

namespace Brainchild.Curriculum.Solutions
{
    internal class Stack<T>
    {
        static readonly int MAX = 1000;
        int top = -1;
        T[] stack = new T[MAX];

        internal bool Push(T data)
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            else
            {
                stack[++top] = data;
                return true;
            }
        }

        internal T Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return default(T);
            }
            else
            {
                T value = stack[top--];
                stack[top + 1] = default(T);
                return value;
            }
        }

        internal T[] Output()
        {
            return stack;
        }
    }


}
