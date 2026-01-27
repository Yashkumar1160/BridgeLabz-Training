using class_library;            
using NUnit.Framework;      
using System;             

namespace nunit_tests
{
    //marks this as test class
    [TestFixture]           
    public class LongTaskTest
    {
        //object declaration
        LongTask task;

        //runs before each test
        [SetUp]             
        public void Setup()
        {
            //object creation
            task = new LongTask(); 
        }

        //marks test method
        [Test]

        //fails if execution > 2 seconds
        [Timeout(2000)]     
        public void Check_Long_Task_Time()
        {
            task.LongRunningTask();       }
    }
}
