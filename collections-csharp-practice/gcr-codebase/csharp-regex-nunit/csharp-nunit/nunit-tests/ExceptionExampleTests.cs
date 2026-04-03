using NUnit.Framework;
using class_library;
using System;

namespace nunit_tests
{
    public class ExceptionExampleTests
    {
        //object 
        ExceptionExample exceptionExample;

        [SetUp]
        public void Setup()
        {
            //create object before each test
            exceptionExample = new ExceptionExample();
        }

        //test for exception
        [Test]
        public void DivideByZero()
        {
            //Assert that exception is thrown
            Assert.Throws<ArithmeticException>(() => exceptionExample.Divide(10, 0));
        }
    }
}
