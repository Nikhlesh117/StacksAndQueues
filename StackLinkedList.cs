using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class StackLinkedList
    {
        public Node top;

        public void Push(int data)
        {
            Node node = new Node(data);

            if (this.top == null)
            {
                this.top = node;
            }
            else
            {
                node.next = this.top;
                this.top = node;

                
            }
            Console.WriteLine("{0} Pushed into stack", node.data);
        }

        public void Display()
        {
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("stack is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }

    }
}
