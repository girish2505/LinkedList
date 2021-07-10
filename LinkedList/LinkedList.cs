﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class MyLinkedList
    {
        Node head;
        public void InsertAtEnd(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                this.head = node;
            }
            else
            {
                Node traverse = this.head;
                while (traverse.next != null)
                {
                    traverse = traverse.next;
                }
                traverse.next = node;
            }
            Console.WriteLine("{0} Inserted into linked list", node.data);
        }
        public void InsertAtBeginning(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                this.head = node;
            }
            else
            {
                node.next = this.head;
                this.head = node;
            }
            Console.WriteLine("{0} Inserted into linked list", node.data);
        }

        public void Display()
        {
            Node temp = this.head;
            while (temp != null)
            {
                if (temp.next != null)
                {
                    Console.Write($"{temp.data} ");
                }
                else
                {
                    Console.WriteLine(temp.data);
                }

                temp = temp.next;
            }
        }
        public void InsertAtPosition(int position, int data)
        {
            Node node = new Node(data);
            Node temp = this.head;
            Node prev = null;
            for (int i = 1; i < position && temp != null; i++)
            {
                prev = temp;
                temp = temp.next;
            }
            prev.next = node;
            node.next = temp;
        }
        public void DeleteFirst()
        {
            if (head == null)
            {
                Console.WriteLine("No element in Linked list");
            }
            else
            {
                Console.WriteLine("After deletion of the first element:");
                head = head.next;
            }
        }
        public void DeleteAtLast()
        {
            if (head == null)
            {
                Console.WriteLine("No element in the list");
            }
            else
            {
                Node temp = head;

                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                temp.next = null;
            }
        }
        public int SearchNode(int val)
        {
            Node temp = this.head;
            int count = 0, Flag= 0;
            while (temp != null)
            {
                count++;
                if (temp.data == val)
                {
                    Flag = 1;
                    break;
                }
                temp = temp.next;
            }
            if (Flag == 1)
            {
                return count;
            }
            else
            {
                return 0;
            }
        }
    }
}
