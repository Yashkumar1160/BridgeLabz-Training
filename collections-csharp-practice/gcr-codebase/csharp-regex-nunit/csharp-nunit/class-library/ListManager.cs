using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_library
{
    public class ListManager
    {
        //method to add element to list
        public void AddElement(List<int> list, int element)
        {
            //add element to list
            list.Add(element);
        }

        //method to remove element from list
        public void RemoveElement(List<int> list, int element)
        {
            //remove element from list
            list.Remove(element);
        }

        //method to get size of list
        public int GetSize(List<int> list)
        {
            //return number of elements in list
            return list.Count;
        }
    }
}
