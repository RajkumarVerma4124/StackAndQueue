using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class StackOperation
    {
        //Performing stack operations
        public static void Perform()
        {
            //Creating a stack(UC1)
            Stack stack = new Stack();

            while (true)
            {
                Console.WriteLine("1: Add Values In Stack \n2: Display Stack Values \n3: Show Top Value \n4: Delete Top Value \n5: Empty The Stack \n6: Exit");
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
                        //Displaying the values in stack(UC1)
                        stack.Display();
                        break;
                    case 3:
                        //Showing the top value in stack(UC2)
                        stack.Peek();
                        break;
                    case 4:
                        //Deleting the top element from the stack(UC2)
                        stack.Pop();
                        break;
                    case 5:
                        //Emptying the stack using peek and pop(UC2)
                        if (stack.IsEmpty())
                            Console.WriteLine("The stack is empty");
                        break;
                    case 6:
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