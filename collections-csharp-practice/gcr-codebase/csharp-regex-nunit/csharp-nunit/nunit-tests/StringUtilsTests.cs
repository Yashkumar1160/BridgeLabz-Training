using class_library;
using NUnit.Framework;
using System;

namespace nunit_tests
{
    [TestFixture]
    public class StringUtilsTests
    {
        //object
        StringUtils utils;

        //runs before every test
        [SetUp]
        public void Setup()
        {
            utils = new StringUtils();
        }

        //test reverse string
        [Test]
        public void Reverse_Test()
        {
            Assert.AreEqual("olleh", utils.Reverse("hello"));
        }

        //test palindrome true
        [Test]
        public void IsPalindrome_True_Test()
        {
            Assert.IsTrue(utils.IsPalindrome("nitin"));
        }

        //test palindrome false
        [Test]
        public void IsPalindrome_False_Test()
        {
            Assert.IsFalse(utils.IsPalindrome("hello"));
        }

        //test uppercase conversion
        [Test]
        public void ToUpperCase_Test()
        {
            Assert.AreEqual("YASH", utils.ToUpperCase("yash"));
        }
    }
}
