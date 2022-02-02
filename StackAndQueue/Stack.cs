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
            Console.WriteLine("{0} is added to the top in stack", newNode.data);
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

        //Method to show the top value in stack(UC2)
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("{0} is top value in stack", this.top.data);
        }

        //Method to delete the top element from the stack(UC2)
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("Top value {0} is deleted", this.top.data);
            this.top = this.top.next;
        }

        //Method to find and delete the top value until stack is empty(UC2)
        public bool IsEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
            return true;
        }
    }
}