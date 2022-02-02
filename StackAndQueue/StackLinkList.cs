using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackAndQueue.LinkListProgram;

namespace StackAndQueue
{
    public class StackLinkList
    {
        //Creating a single linklist(UC1)
        LinkedList list = new LinkedList();

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

        //Method to show the top value in stack using linklist(UC2)
        public void PeekStack()
        {
            list.Peek();
        }

        //Method to delete the top element from the stack using linklist(UC2)
        public void PopStack()
        {
            list.DeleteFirst();
        }

        //Method to delete the top value until its empty using linklist(UC2)
        public bool IsEmptyStack()
        {
            while (list.head != null)
                list.DeleteFirst();
            return true;
        }

    }
}