using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedList;
using System.Collections.Generic;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        MyLinkedList list;
        [TestInitialize]
        public void SetUp()
        {
            list = new MyLinkedList();
        }
        [TestMethod]
        public void TestMethod1()
        {
            list.InsertAtEnd(56);
            list.InsertAtEnd(30);
            list.InsertAtEnd(70);
            int position = list.SearchNode(30);
            if (position > 0)
            {
                list.InsertAtPosition(position + 1,40);
            }
        }
    }
}
