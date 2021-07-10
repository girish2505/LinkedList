using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List implementation!");
            LinkedList list = new LinkedList();
            list.InsertAtBeginning(56);
            list.InsertAtBeginning(30);
            list.InsertAtBeginning(70);
            list.Display();
        }
    }
}
