﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue.LinkListProgram
{
    public class LinkedList
    {
        public Node head;

        public LinkedList()
        {
            this.head = null;
        }

        //Refactored the lastadd method to take element to get in sorted order(UC10)
        public void Add(int data)
        {
            Node newNode = new Node(data);
            Node currentNode = this.head, previousNode = null;
            while (currentNode != null && currentNode.data < newNode.data)
            {
                previousNode = currentNode;
                currentNode = currentNode.next;
            }
            if (previousNode == null)
                this.head = newNode;
            else
            {
                previousNode.next = newNode;
            }
            newNode.next = currentNode;
            Console.WriteLine("{0} is inserted into linklist to get sorted\n", newNode.data);
        }

        //Creating add first method to add the element at first position i.e head(UC2)
        public int AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.next = this.head;
            this.head = newNode;
            return newNode.data;
        }

        //Creating append method to add the element at last position i.e tail(UC3)
        public void Append(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.Write("{0} is append into linklist \n", node.data);
        }

        //Inserting the element at particular index(UC4 & UC8)
        public void InsertAt(int index, int data)
        {
            Node node = new Node(data);
            if (index < 0)
                Console.WriteLine("Invalid Position");
            else if (this.head == null)
                Console.WriteLine("LinkList Is Empty");
            else if (index == 0)
                AddFirst(data);
            else
            {
                Node temp = this.head;
                for (int i = 0; i < index - 1; i++)
                {
                    temp = temp.next;
                }
                node.next = temp.next;
                temp.next = node;
                Console.WriteLine("Element Is Inserted\n");
            }
        }

        //Deleting the first element(UC5)
        public int DeleteFirst()
        {
            if (this.head == null)
                Console.WriteLine("LinkList Is Empty");
            int deletedNode = this.head.data;
            this.head = this.head.next;
            return deletedNode;
        }

        //Deleting the last element(UC6)
        public int DeleteLast()
        {
            Node newNode = this.head;
            if (this.head == null)
            {
                Console.WriteLine("LinkList Is Empty");
                return default;
            }
            else if (this.head.next == null)
            {
                int deletedNode = this.head.data;
                this.head = null;
                return deletedNode;
            }
            else if (this.head != null && this.head.next != null)
            {
                while (newNode.next.next != null)
                {
                    newNode = newNode.next;
                }
            }
            int lastDeletedNode = newNode.next.data;
            newNode.next = null;
            return lastDeletedNode;
        }

        //Search the node element(UC7 & UC8)
        public int Search(int data)
        {
            int index = -1;
            Node temp = this.head;
            while (temp != null)
            {
                if (temp.data == data)
                {
                    index++;
                    return index;
                }
                index++;
                temp = temp.next;
            }
            Console.WriteLine("{0} is not present in the current linklist", data);
            return -1;
        }

        //Deleting the given element from linklist(UC9)
        public int Delete(int data)
        {
            if (this.head == null)
            {
                Console.WriteLine("List is Empty");
            }
            else
            {
                int indexDel = Search(data);
                if (indexDel == -1)
                {
                    return 0;
                }
                else if (indexDel == 0)
                {
                    this.head = this.head.next;
                    return data;
                }
                else
                {
                    Node temp = this.head;
                    Node newTemp;
                    for (int i = 0; i < indexDel - 1; i++)
                    {
                        temp = temp.next;
                    }
                    newTemp = temp.next;
                    temp.next = newTemp.next;
                    return data;
                }
            }
            return default;
        }

        //Implementing the size of the list(UC9)
        public int Size()
        {
            int size = 0;
            Node temp = this.head;
            while (temp != null)
            {
                size++;
                temp = temp.next;
            }
            return size;
        }

        //Displaying the data from linklist nodes(UC1 & UC2)
        public void Display()
        {
            //Storing the head to temp node
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkList Is Empty");
                Console.ReadLine();
            }
            else
            {
                Console.Write("The Elements In LinkList Are : ");
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.ReadLine();
            }
        }
    }
}