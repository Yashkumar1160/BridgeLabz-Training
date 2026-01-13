using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.cinema_time
{
    internal class MovieUtilityImpl : IMovie 
    {
        //list to store movie titles
        Movie[] movies = new Movie[100];

        static int totalMovies = 0;

        //method to add movie 
        public void AddMovie(Movie movie)
        {
            movies[totalMovies] = movie;
            
            totalMovies++;
        }


        //method to search for a movie
        public void SearchMovie(string keyword)
        {
            if (totalMovies == 0)
            {
                Console.WriteLine("\nNO MOVIES YET");
                return;
            }

            //flag to check if movie is present 
            bool flag=false;
         
            //loop through movie titles list
            for(int i=0;i<totalMovies;i++) 
            {
                //check for movie
                if (movies[i].Title.ToLower().Contains(keyword.ToLower()))
                {
                    //update flag
                    flag = true;

                    //display movie 
                    Console.WriteLine(string.Format("\nMOVIE TITLE: {0}", movies[i].Title));
                }
            }

            //if movie not found
            if (flag == false)
            {
                Console.WriteLine("\nMOVIE NOT FOUND");
            }
        }


        public void DisplayAllMovies()
        {
            if (totalMovies == 0)
            {
                Console.WriteLine("\nNO MOVIES YET");
                return;
            }

            for(int i=0;i<totalMovies;i++)
            {
                Console.WriteLine(string.Format("\nMOVIE {0} \nTIME: {1}", movies[i].Title,movies[i].Time));
            }
        }
    }
}
