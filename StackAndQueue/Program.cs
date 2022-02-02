using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the stack and queue program");
            Console.ReadLine();

            //Creating a stack(UC1)
            Stack stack = new Stack();

            while (true)
            {
                Console.WriteLine("1: Add Values In Stack \n2: Add Values In Stack Using LinkList \n3: Display Stack Values \n4: Display Stack Values Using LinkList" +
                                  "\n5: Exit");
                Console.Write("Enter A Choice From Above : ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //Adding the value in stack(UC1)
                        Console.Write("Enter A Value To Add In Stack : ");
                        int numStack = int.Parse(Console.ReadLine());
                        stack.Push(numStack);
                        break;
                    case 2:
                        //Adding the value in stack using linklist(UC1)
                        Console.Write("Enter A Value To Add In Stack Using LinkList : ");
                        int numList = int.Parse(Console.ReadLine());
                        stack.PushStack(numList);
                        break;
                    case 3:
                        //Displaying the values in stack(UC1)
                        stack.Display();
                        break;
                    case 4:
                        //Displaying the values in stack using linklist(UC1)
                        stack.DisplayStack();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter A RIght Choice");
                        continue;
                }
            }
        }
    }
}
