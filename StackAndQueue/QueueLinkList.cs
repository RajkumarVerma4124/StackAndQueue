using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackAndQueue.LinkListProgram;

namespace StackAndQueue
{
    //Creating Queue using linklist
    public class QueueLinkList
    {
        //creating a object for linklist(UC3)
        LinkedList list = new LinkedList();

        //Using LinkedList to do the queue operation for adding value(UC3)
        public void Enqueue(int data)
        {
            list.Append(data);
        }

        //Using linkedlist to display queue values(UC3)
        public void Display()
        {
            list.Display();
        }
    }
}
