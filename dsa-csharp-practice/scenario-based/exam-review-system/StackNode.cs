using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.exam_review_system
{
    internal class StackNode
    {
        public int questionNumber;
        public StackNode Next;

        public StackNode(int questionNumber)
        {
            this.questionNumber = questionNumber;
            this.Next = null;
        }
    }
}
