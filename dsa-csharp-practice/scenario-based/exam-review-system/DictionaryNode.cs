using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.exam_review_system
{
    internal class DictionaryNode
    {
        //attributes
        public int question;
        public string answer;
        public DictionaryNode Next;

        //constructor
        public DictionaryNode(int question, string answer)
        {
            this.question = question;
            this.answer = answer;
            Next = null;
        }
    }
}
