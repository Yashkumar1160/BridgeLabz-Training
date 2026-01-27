using class_library;      
using NUnit.Framework;    
using System;           

namespace nunit_tests
{
    //marks test class
    [TestFixture]           
    public class NumberUtilsTest
    {
        //object declaration
        EvenNumbers utils; 

        //runs before each test
        [SetUp]
        public void Setup()
        {
            //creating object
            utils = new EvenNumbers(); 
        }

        //test case 1
        [TestCase(2, true)]
        //test case 2
        [TestCase(4, true)]
        //test case 3
        [TestCase(7, false)]
        //test case 4
        [TestCase(9, false)]
        public void Check_Even_Number(int num, bool expected)
        {
            //call IsEven method
            bool result = utils.IsEven(num);    
            Assert.AreEqual(expected, result);  
        }
    }
}
