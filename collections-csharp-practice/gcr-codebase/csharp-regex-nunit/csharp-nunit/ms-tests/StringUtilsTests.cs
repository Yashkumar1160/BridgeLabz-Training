using class_library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ms_tests
{
    [TestClass]
    public class StringUtilsTests
    {
        //object
        StringUtils utils;

        //runs before every test
        [TestInitialize]
        public void Setup()
        {
            utils = new StringUtils();
        }

        //test reverse string
        [TestMethod]
        public void Reverse_Test()
        {
            Assert.AreEqual("olleh", utils.Reverse("hello"));
        }

        //test palindrome true 
        [TestMethod]
        public void IsPalindrome_True_Test()
        {
            Assert.IsTrue(utils.IsPalindrome("nitin"));
        }

        //test palindrome false
        [TestMethod]
        public void IsPalindrome_False_Test()
        {
            Assert.IsFalse(utils.IsPalindrome("hello"));
        }

        //test uppercase conversion
        [TestMethod]
        public void ToUpperCase_Test()
        {
            Assert.AreEqual("YASH", utils.ToUpperCase("yash"));
        }
    }
}

