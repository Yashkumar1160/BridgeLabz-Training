using NUnit.Framework;
using class_library;
using System;
using System.IO;

namespace nunit_tests
{
    //marks test class
    [TestFixture] 
    public class FileProcessorTest
    {
        //declare object
        FileProcessor processor;

        //runs before each test
        [SetUp]
        public void Setup()
        {
            //create object
            processor = new FileProcessor();
        }

        //test writing and reading file
        [Test] 
        public void Test_WriteReadFile()
        {
            //file name
            string filename = "test.txt";
            //content to write
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

        //test exception when file does not exist
        [Test]
        public void Test_FileNotExist()
        {
            //file that do not exist
            string filename = "nonexistent.txt"; 

            //check if reading throws IOException
            Assert.Throws<IOException>(() => processor.ReadFromFile(filename));
        }
    }
}
