using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.exam_review_system
{
    internal interface IExamProctor
    {
        //method to add questions and answers
        void AddQuestionsAndAnswers();

        //method to update answers
        void UpdateAnswers();
        
        //method to visit question
        void VisitQuestion();
        
        //method to submit answer
        void SubmitAnswer();

        //method to show navigation stack
        void ShowQuestionsNavigation();
        
        //method to go back to previous question
        void GoBack();

        //method to evaluate exam score
        void EvaluateExam(Student student);
    }
}
