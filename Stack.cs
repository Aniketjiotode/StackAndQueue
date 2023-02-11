using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    internal class Stack<T>
    {
        int capacity;
       public T[] St;
        int top = -1;
        public Stack(int capacity)
        {
            this.capacity = capacity;
            St = new T[capacity];
        }
        public bool Push(T data)
        {
            if (top == capacity - 1)
            {
                Console.WriteLine("Stack overFlow");
                return false;
            }
            St[++top] = data;
            return true;
        }
        
    }
}
