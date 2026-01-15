using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.browser_buddy
{
    internal class BrowserNode
    {
        //store url of web page
        public string Url;

        //previous page pointer
        public BrowserNode Prev;

        //next page pointer
        public BrowserNode Next;

        //constructor
        public BrowserNode(string url)
        {
            Url = url;
        }
    }
}
