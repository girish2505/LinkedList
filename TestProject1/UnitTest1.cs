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
            list.InsertAtEnd(40);
            list.InsertAtEnd(70);
            list.DeleteNode(40);
            int actual = list.Size();
            int expect = 3;
            Assert.AreEqual(actual, expect);
        }
    }
}
