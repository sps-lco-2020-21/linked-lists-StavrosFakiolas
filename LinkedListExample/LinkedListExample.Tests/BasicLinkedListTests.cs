using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListExample.Lib;

namespace LinkedListExample.Tests
{
    [TestClass]
    public class BasicLinkedListTests
    {
        [TestMethod]
        public void TestEmpty()
        {
            var ill = new IntegerLinkedList();
            Assert.AreEqual(0, ill.Count);
        }

        [TestMethod]
        public void TestCount()
        {
            var ill = new IntegerLinkedList(5);
            ill.Append(7);
            ill.Append(9);
            Assert.AreEqual(3, ill.Count);
        }

        [TestMethod]
        public void TestSum()
        {
            var ill = new IntegerLinkedList(5);
            ill.Append(7);
            ill.Append(9);
            Assert.AreEqual(21, ill.Sum);
        }

        [TestMethod]
        public void TestToStringExplicit()
        {
            var ill = new IntegerLinkedList(5);
            ill.Append(7);
            ill.Append(9);
            Assert.AreEqual("{5, 7, 9}", ill.ToString());


        }
        [TestMethod]
        public void TestRemove()
        {
            var ill = new IntegerLinkedList(5);
            ill.Append(7);
            ill.Append(9);
            ill.Remove(7);
            ill.Remove(5);
            ill.Remove(9);
            Assert.AreEqual(0, ill.Sum);

        }
    }
}
