using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.exam_review_system
{
    internal class AnswerDictionary
    {
        //head node
        DictionaryNode head;


        //method to add answer
        public void AddAnswer(int question,string answer)
        {
            //if question is already answered then update it 
            if(ContainsKey(question))
            {
                Update(question, answer);
                return;
            }

            // create new node
            DictionaryNode node = new DictionaryNode(question, answer);

            //if dictionary empty
            if (head == null)
            {
                head = node;
                return;
            }

            //traverse till last
            DictionaryNode temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            temp.Next = node;
        }



        //method to check if question exists
        public bool ContainsKey(int question)
        {
            //store head in temp variable
            DictionaryNode temp = head;

            //traverse list
            while (temp != null)
            {
                //if question exists
                if (temp.question == question)
                {
                    return true;
                }

                //update temp
                temp = temp.Next;
            }
            return false;
        }


        //method to get answer by question id
        public string Get(int question)
        {
            //store head in temp variable
            DictionaryNode temp = head;

            //traverse list
            while (temp != null)
            {
                //if question is found
                if (temp.question == question)
                {
                    return temp.answer;
                }

                //update temp
                temp = temp.Next;
            }
            return null;
        }


        //method to update answer
        public bool Update(int question, string newAnswer)
        {
            //store head in temp variable
            DictionaryNode temp = head;

            //traverse list
            while (temp != null)
            {
                //if question is found
                if (temp.question == question)
                {
                    temp.answer = newAnswer;
                    return true;
                }

                //update temp
                temp = temp.Next;
            }
            return false;
        }


        //method to remove answer
        public bool Remove(int question)
        {
            //if no question exists
            if (head == null)
            {
                return false;
            }

            //if question is found
            if (head.question == question)
            {
                head = head.Next;
                return true;
            }

            //store previous node and current node
            DictionaryNode prev = head;
            DictionaryNode curr = head.Next;

            //traverse list
            while (curr != null)
            {
                //if question is found
                if (curr.question == question)
                {
                    prev.Next = curr.Next;
                    return true;
                }

                //update previous and current
                prev = curr;
                curr = curr.Next;
            }
            return false;
        }


        //method get head for traversal
        public DictionaryNode GetHead()
        {
            return head;
        }
    }
}
