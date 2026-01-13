using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.cinema_time
{
    internal class Movie
    {
        //variable to store movie title
        private string title;

        //variable to store movie time
        private string time;

        //getter and setter for movie title
        public string Title
        {
            get {  return title; } 
            set {  title = value; }
        }

        //getter and setter for movie time
        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        //constructor
        public Movie(string movieName, string time)
        {
            Title = movieName;
            Time = time;
        }

    }
}
