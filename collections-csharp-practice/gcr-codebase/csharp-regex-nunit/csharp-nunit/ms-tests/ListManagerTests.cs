using class_library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ms_tests
{
    [TestClass]
    public class ListManagerTests
    {
        //object 
        ListManager manager;

        //list of numbers
        List<int> numbers;

        //runs before every test
        [TestInitialize]
        public void Setup()
        {
            manager = new ListManager();
            numbers = new List<int>();
        }

        //test add element
        [TestMethod]
        public void AddElement_Test()
        {
            manager.AddElement(numbers, 10);

            Assert.AreEqual(1, manager.GetSize(numbers));
            Assert.IsTrue(numbers.Contains(10));
        }

        //test remove element
        [TestMethod]
        public void RemoveElement_Test()
        {
            numbers.Add(10);
            numbers.Add(20);

            manager.RemoveElement(numbers, 10);

            Assert.AreEqual(1, manager.GetSize(numbers));
            Assert.IsFalse(numbers.Contains(10));
        }

        //test list size
        [TestMethod]
        public void GetSize_Test()
        {
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            Assert.AreEqual(3, manager.GetSize(numbers));
        }
    }
}
