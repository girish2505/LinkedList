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
            //list.InsertAtEnd(30);
            list.InsertAtEnd(70);
            list.Display();
            Console.WriteLine("\nEnter position where you want to add element");
            int pos = Convert.ToInt32(Console.ReadLine());
            list.InsertAtPosition(pos,30);
            list.Display();
        }
    }
}
