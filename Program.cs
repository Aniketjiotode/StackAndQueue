using System;

namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Stack<int> st = new Stack<int> (3);
            st.Push (56);
            st.Push (30);
            st.Push (76);
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Peek());
           for(int i=0; i<3; i++)
            {
                Console.WriteLine(st.St[i]);
            }
        }
    }
}
