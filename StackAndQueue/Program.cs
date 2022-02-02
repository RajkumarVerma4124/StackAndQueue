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
                Console.WriteLine("1: Perform Stack Operation \n2: Perform Stack Operation Using LinkList \n3: Exit");
                Console.WriteLine("Enter The Choice From The Above");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //Performing the stack operation(UC2)
                        StackOperation.Perform();
                        break;
                    case 2:
                        //Performing the stack Operation using linklist(UC2)
                        StackLinkListOperation.Perform();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        continue;
                }
            }
        }
    }
}
