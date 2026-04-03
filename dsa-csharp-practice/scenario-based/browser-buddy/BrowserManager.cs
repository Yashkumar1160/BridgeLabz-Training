using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.browser_buddy
{
    internal class BrowserManager
    {
        //create object of Browser class
        private Browser currentTab = new Browser();

        //create stack to store closed tab
        private Stack<Browser> closedTabs = new Stack<Browser>();

        
        //method to visit url
        public void Visit()
        {
            //take url
            Console.Write("ENTER URL: ");
            string url = Console.ReadLine();

            //visit url
            currentTab.Visit(url);
        }

        //method to visit backward page
        public void Back()
        {
            currentTab.Back();
        }

        //method to visit forward page
        public void Forward()
        {
            currentTab.Forward();
        }

        //method to close tab
        public void CloseTab()
        {
            //push current tab in stack
            closedTabs.Push(currentTab);

            //open new tab
            currentTab = new Browser();
            Console.WriteLine("TAB CLOSED");
        }


        //method to restore closed tab
        public void RestoreTab()
        {
            //if closed tab exists in stack
            if (closedTabs.Count > 0)
            {
                //restore last tab
                currentTab = closedTabs.Pop();
                Console.WriteLine("TAB RESTORED. CURRENT PAGE: " + currentTab.GetCurrentPage());
            }
            //if no closed tab is present
            else
            {
                Console.WriteLine("NO CLOSED TABS TO RESTORE");
            }
        }


        //method to display current page
        public void ShowCurrentPage()
        {
            Console.WriteLine("Current Page: " + currentTab.GetCurrentPage());
        }
    }
}
