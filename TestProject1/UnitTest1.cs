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
            int actual = list.SearchNode(30);
            int expect = 2;
            Assert.AreEqual(actual, expect);
        }
    }
}
