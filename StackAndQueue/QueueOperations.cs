using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class QueueOperations
    {
        //Performing queue operations
        public static void Perform()
        {
            //Creating a Queue(UC3)
            Queue queue = new Queue();

            while (true)
            {
                Console.WriteLine("1: Add Values In Queue \n2: Display Queue Values \n3: Exit");
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
