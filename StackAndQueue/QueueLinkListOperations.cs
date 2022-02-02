using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class QueueLinkListOperations
    {
        //Performing queue operations using linklist
        public static void Perform()
        {
            //Creating a queue using linklist(UC3)
            QueueLinkList queue = new QueueLinkList();

            while (true)
            {
                Console.WriteLine("1: Add Values In Queue Using LinkList \n2: Display Queue Values Using LinkList \n3: Exit");
                Console.Write("Enter A Choice From Above : ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //Adding the value in stack(UC1)
                        Console.Write("Enter A Value To Add In Queue : ");
                        int numQueue = int.Parse(Console.ReadLine());
                        queue.Enqueue(numQueue);
                        break;
                    case 2:
                        //Displaying the values in queue(UC3)
                        queue.Display();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter A Right Choice");
                        continue;
                }
            }
        }
    }
}
