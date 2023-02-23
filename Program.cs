using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Stacks And Queues");
            Console.WriteLine("----------------------------");


            QueueLinkedList queue = new QueueLinkedList();

            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Display();
        }
    }
}
