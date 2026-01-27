using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_library
{
    public class FileProcessor
    {
        //method to write content to a file
        public void WriteToFile(string filename, string content)
        {
            File.WriteAllText(filename, content); 
        }

        //method to read content from a file
        public string ReadFromFile(string filename)
        {
            return File.ReadAllText(filename); 
        }
    }
}
