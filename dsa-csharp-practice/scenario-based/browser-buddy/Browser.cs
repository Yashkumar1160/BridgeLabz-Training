using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.browser_buddy
{
    internal class Browser
    {
        //current node
        private BrowserNode current;

        //method to visit new url
        public void Visit(string url)
        {
            //create object of BrowserNode for history
            BrowserNode node = new BrowserNode(url);

            //check if there is an existing page
            if (current != null)
            {
                //clear forward history
                current.Next = null;
                
                //link new node with current node
                node.Prev = current;
                current.Next = node;
            }

            current = node;
            Console.WriteLine("VISITED: " + url);
        }


        //method to visit previous page
        public void Back()
        {
            //check if previous page exists
            if (current != null && current.Prev != null)
            {
                current = current.Prev;
                Console.WriteLine("BACK TO: " + current.Url);
            }
            //if no backward page is found
            else
            {
                Console.WriteLine("NO BACK HISTORY");
            }
        }


        //method to visit forward page
        public void Forward()
        {
            //check if forward page exists
            if (current != null && current.Next != null)
            {
                current = current.Next;
                Console.WriteLine("FORWARD TO: " + current.Url);
            }
            //if no forward page is found
            else
            {
                Console.WriteLine("NO FORWARD HISTORY");
            }
        }


        //method to get current page
        public string GetCurrentPage()
        {
            return current == null ? "EMPTY TAB" : current.Url;
        }
    }
}
