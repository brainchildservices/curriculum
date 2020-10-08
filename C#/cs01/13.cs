using System;
using System.Collections;
namespace Brainchild.Curriculum.Solutions
{
    //Implement push and pop using Generics.
    public class StackPushPop<T>
    {
        static int MAX = 1000;
        static int index = -1;
        T[] stack = new T[MAX];
        public void Push(T data)
        {
            index = index + 1;
            stack[index] = data;
        }
        public T Pop()
        {
            T[] stackNew = new T[MAX];
            T value = stack[index];
            stack[index]=default(T); // Reset last element to default value of the data type
            index = index - 1;
            return value;
        }
        internal T[] PrintStack()
        {
            return stack;
        }
    }
}