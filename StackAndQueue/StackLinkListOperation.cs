using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class StackLinkListOperation
    {
        //Performing stack operation using linklist
        public static void Perform()
        {
            //Creating a stack(UC1)
            StackLinkList stack = new StackLinkList();

            while (true)
            {
                Console.WriteLine("1: Add Values In Stack Using LinkList \n2: Display Stack Values Using LinkList \n3: Show Top Value Using LinkList \n4: Delete Top Value Using LinkList" +
                                 "\n5: Empty The Stack Using LinkList \n6: Exit");
                Console.Write("Enter A Choice From Above : ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //Adding the value in stack using linklist(UC1)
                        Console.Write("Enter A Value To Add In Stack Using LinkList : ");
                        int numList = int.Parse(Console.ReadLine());
                        stack.PushStack(numList);
                        break;
                    case 2:
                        //Displaying the values in stack using linklist(UC1)
                        stack.DisplayStack();
                        break;
                    case 3:
                        //Showing the top value in stack using linklist(UC2)
                        stack.PeekStack();
                        break;
                    case 4:
                        //Deleting the top element from the stack using linklist(UC2)
                        stack.PopStack();
                        break;
                    case 5:
                        //Emptying the stack using linklist operation(UC2)
                        if (stack.IsEmptyStack())
                            Console.WriteLine("The Stack is empty using linklist");
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