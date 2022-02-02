using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackAndQueue.LinkListProgram;

namespace StackAndQueue
{
    public class Stack
    {
        private Node top;
        public Stack()
        {
            this.top = null;
        }

        //Creating a single linklist(UC1)
        LinkedList list = new LinkedList();

        //Creating a push method in stack to add values at top(UC1)
        public void Push(int data)
        {
            Node newNode = new Node(data);
            if (this.top != null)
            {
                newNode.next = this.top;
                top = newNode;
            }
            this.top = newNode;
            Console.WriteLine("{0} New node is added to the top", newNode.data);
        }

        //Creating a push method using linklist to add values(UC1)
        public void PushStack(int data)
        {
            list.AddFirst(data);
        }

        //Creating a display method using linklist to show values(UC1)
        public void DisplayStack()
        {
            list.Display();
        }

        //Creating a display method in stack to view values(UC1)
        public void Display()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Node temp = this.top;
                while (temp != null)
                {
                    Console.WriteLine("Stack contain value : {0}", temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}