using Microsoft.VisualStudio.TestTools.UnitTesting;
using class_library;
using System;
using System.IO; 

namespace ms_tests
{
    //marks test class
    [TestClass] 
    public class FileProcessorTest
    {
        //declare object
        FileProcessor processor;

        //runs before each test
        [TestInitialize]    
        public void Setup()
        {
            //create object
            processor = new FileProcessor();
        }

        //test writing and reading file
        [TestMethod] 
        public void Test_WriteReadFile()
        {
            //File name
            string filename = "test.txt";

            //content
            string content = "Hello World";

            //write content into file
            processor.WriteToFile(filename, content);

            //check if file exists
            Assert.IsTrue(File.Exists(filename));

            //read content from file
            string readContent = processor.ReadFromFile(filename);

            //check if content is same
            Assert.AreEqual(content, readContent);

            //delete file after test
            File.Delete(filename);
        }

        [TestMethod]
        public void Test_FileNotExist()
        {
            string filename = "nonexistent.txt";

            // Assert that ReadFromFile throws an IOException
            Assert.Throws<IOException>(() => processor.ReadFromFile(filename));
        }


    }
}
