using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackAndQueue.LinkListProgram;

namespace StackAndQueue
{
    //Creating Queue
    public class Queue
    {
        private Node head;
        public Queue()
        {
            this.head = null;
        }

        //Method to insert the node into Queue(UC3)
        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
                this.head = newNode;
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
            Console.WriteLine("{0} is inserted into queue ", newNode.data);
        }

        //Method to display the value in Queue(UC3)
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data+" ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
