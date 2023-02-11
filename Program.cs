using System;

namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Queue<int> que = new Queue<int> (3);
            que.Enqueue (56);
            que.Enqueue (30);
            que.Enqueue (76);
            Console.WriteLine(que.Dequeue());   
            Console.WriteLine(que.Dequeue());   
            Console.WriteLine(que.Dequeue());   
           for(int i=0; i<3; i++)
            {
                Console.WriteLine(que.obj[i]);
            }
        }
    }
}
