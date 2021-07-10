using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List implementation!");
            LinkedList list = new LinkedList();
            list.InsertAtEnd(56);
            list.InsertAtEnd(30);
            list.InsertAtEnd(70);
            list.Display();
        }
    }
}
