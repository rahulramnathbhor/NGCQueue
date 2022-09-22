using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGCQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(15);
            q.Enqueue(11);
            q.Enqueue(12);
            q.Enqueue(13);
            q.Enqueue(14);
            q.Dequeue();
            q.Dequeue();
            q.Peek();   

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }
    }
}
