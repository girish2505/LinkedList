using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList
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
            Console.WriteLine("{0} Inserted into linked list",node.data);
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
                    Console.WriteLine( temp.data );
                }

                temp = temp.next;
            }
        }
    }
}
