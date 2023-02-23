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

            StackLinkedList stack= new StackLinkedList();

            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();

        }
    }
}
