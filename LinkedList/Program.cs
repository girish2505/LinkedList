using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List implementation!");
            MyLinkedList list = new MyLinkedList();
            list.InsertAtEnd(56);
            list.InsertAtEnd(30);
            list.InsertAtEnd(70);
            list.Display();
            Console.WriteLine("Enter position");
            int pos = Convert.ToInt32(Console.ReadLine());
            list.InsertAtPosition(pos,40);
            list.Display();
        }
    }
}
