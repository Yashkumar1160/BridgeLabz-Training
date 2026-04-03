using System;                                     
using Microsoft.VisualStudio.TestTools.UnitTesting;
using class_library;                                  

namespace ms_tests
{
    //marks test class
    public class NumberUtilsTest
    {
        //object declaration
        EvenNumbers utils;

        //runs before each test
        [TestInitialize]                          
        public void Setup()
        {
            //object creation
            utils = new EvenNumbers();              
        }

        //marks test method
        [TestMethod]
        //test case 1
        [DataRow(2, true)]
        //test case 2
        [DataRow(4, true)]
        //test case 3
        [DataRow(7, false)]
        //test case 4
        [DataRow(9, false)]                         
        public void Check_Even_Number(int num, bool expected)
        {
            //call IsEven method
            bool result = utils.IsEven(num);        
            Assert.AreEqual(expected, result);      
        }
    }
}
