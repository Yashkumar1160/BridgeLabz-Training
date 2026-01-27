using class_library;                         
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ms_tests
{
    //marks test class
    [TestClass]                           
    public class LongTaskTests
    {
        //object declaration
        LongTask task;

        //runs before each test
        [TestInitialize]                
        public void Setup()
        {
            //object creation
            task = new LongTask();        
        }

        //marks test method
        [TestMethod]

        //fails if takes more than 2 seconds
        [Timeout(2000)]                  
        public void Check_Long_Task_Time()
        {

            task.LongRunningTask();        
        }
    }
}
