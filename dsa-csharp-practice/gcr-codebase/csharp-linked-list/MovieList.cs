using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_linked_list
{
    internal class MovieNode
    {

        //movie attributes
        public string title;

        public string director;

        public int year;

        public double rating;

        //pointers for doubly linked list
        public MovieNode next;
        public MovieNode prev;

        //constructor
        public MovieNode(string title, string director, int year, double rating)
        {
            this.title = title;
            this.director = director;
            this.year = year;
            this.rating = rating;
        }
    }

    class MovieList
    {
        //head and tail nodes
        MovieNode head;
        MovieNode tail;

        //method to add movie at beginning
        public void AddAtBeginning(MovieNode node)
        {
            //check if list is empty
            if (head == null)
            {
                head = tail = node;
                return;
            }

            //line new node with current head
            node.next = head;
            head.prev = node;
            head = node;
        }

        //method to add movie at last
        public void AddAtLast(MovieNode node)
        {
            //check if list is empty
            if (tail == null)
            {
                head = tail = node;
                return;
            }

            //link new node with tail
            tail.next = node;
            node.prev = tail;

            //update tail
            tail = node;
        }

        //method to add movie at specific position
        public void AddAtPosition(MovieNode node, int position)
        {
            //if position is first or list is empty
            if (position <= 1 || head == null)
            {
                AddAtBeginning(node);
                return;
            }

            //store head in temp variable
            MovieNode temp = head;
            int count = 1;

            //loop through list to move to desired position
            while (temp.next != null && count < position - 1)
            {
                temp = temp.next;
                count++;
            }

            //update links 
            node.next = temp.next;
            node.prev = temp;

            if (temp.next != null)
            {
                temp.next.prev = node;
            }
            else
            {
                tail = node;
            }

            temp.next = node;
        }

        //method to remove movie by title
        public void RemoveMovie(string title)
        {
            //store head in temp variable
            MovieNode temp = head;

            //loop through list
            while (temp != null)
            {
                //check if movie title matches
                if (temp.title.Equals(title))
                {
                    //if node is head
                    if (temp == head)
                    {
                        head = head.next;
                        if (head != null) head.prev = null;
                    }
                    //if node is tail
                    else if (temp == tail)
                    {
                        tail = tail.prev;
                        tail.next = null;
                    }
                    //if node is in between
                    else
                    {
                        temp.prev.next = temp.next;
                        temp.next.prev = temp.prev;
                    }
                    Console.WriteLine("MOVIE REMOVED SUCCESSFULLY");
                    return;
                }
                //update temp
                temp = temp.next;
            }

            Console.WriteLine("MOVIE NOT FOUND");
        }

        //method to search movie by director
        public void SearchMovieByDirector(string director)
        {
            //store head in temp variable
            MovieNode temp = head;

            bool found = false;


            //loop through list
            while (temp != null)
            {
                //check director name
                if (temp.director.Equals(director))
                {
                    DisplayMovie(temp);
                    found = true;
                }
                temp = temp.next;
            }

            //if no movie found
            if (!found)
            {
                Console.WriteLine("NO MOVIE FOUND FOR GIVEN DIRECTOR");
            }
        }

        //method to search movie by rating
        public void SearchMovieByRating(double rating)
        {
            //store head in temp variable
            MovieNode temp = head;

            bool found = false;

            //loop through list
            while (temp != null)
            {
                //check movie rating
                if (temp.rating == rating)
                {
                    DisplayMovie(temp);
                    found = true;
                }
                temp = temp.next;
            }

            //if no movie found
            if (!found)
            {
                Console.WriteLine("NO MOVIE FOUND FOR GIVEN RATING");
            }
        }

        //method to update movie rating
        public void UpdateRating(string title, double newRating)
        {
            //store head in temp variable
            MovieNode temp = head;

            //loop through list
            while (temp != null)
            {
                //check movie title
                if (temp.title.Equals(title))
                {
                    temp.rating = newRating;
                    Console.WriteLine("RATING UPDATED SUCCESSFULLY");
                    return;
                }
                temp = temp.next;
            }

            Console.WriteLine("MOVIE NOT FOUND");
        }

        //method to display movies forward
        public void DisplayForward()
        {
            //check if list is empty
            if (head == null)
            {
                Console.WriteLine("NO MOVIES AVAILABLE");
                return;
            }

            //store head in temp variable
            MovieNode temp = head;

            //loop through list
            while (temp != null)
            {
                DisplayMovie(temp);
                temp = temp.next;
            }
        }

        //method to display movies in reverse
        public void DisplayReverse()
        {
            //check if list is empty
            if (tail == null)
            {
                Console.WriteLine("NO MOVIES AVAILABLE");
                return;
            }

            //store tail in temp variable
            MovieNode temp = tail;

            //loop backwards
            while (temp != null)
            {
                DisplayMovie(temp);
                temp = temp.prev;
            }
        }

        //method to display single movie
        public void DisplayMovie(MovieNode movie)
        {
            Console.WriteLine("\nMOVIE TITLE: " + movie.title);
            
            Console.WriteLine("DIRECTOR: " + movie.director);
           
            Console.WriteLine("YEAR OF RELEASE: " + movie.year);
           
            Console.WriteLine("RATING: " + movie.rating);
           
            Console.WriteLine("-----------------------------------------");
        }

        //main method
        public static void Main(string[] args)
        {
            //create movie list
            MovieList movieList = new MovieList();

            //create movie nodes
            MovieNode m1 = new MovieNode("Inception", "Christopher Nolan", 2010, 8.8);

            MovieNode m2 = new MovieNode("Interstellar", "Christopher Nolan", 2014, 8.6);

            MovieNode m3 = new MovieNode("Avatar", "James Cameron", 2009, 7.8);

            MovieNode m4 = new MovieNode("Titanic", "James Cameron", 1997, 7.9);

            MovieNode m5 = new MovieNode("Joker", "Todd Phillips", 2019, 8.4);

            //add movies
            movieList.AddAtBeginning(m1);

            movieList.AddAtLast(m2);

            movieList.AddAtLast(m3);

            Console.WriteLine("\nMOVIES AFTER ADDING AT BEGINNING AND LAST:");
            movieList.DisplayForward();

            //add at specific position
            movieList.AddAtPosition(m4, 2);

            Console.WriteLine("\nMOVIES AFTER ADDING AT POSITION 2:");
            movieList.DisplayForward();

            //add another movie
            movieList.AddAtLast(m5);

            Console.WriteLine("\nMOVIES AFTER ADDING ONE MORE MOVIE:");
            movieList.DisplayForward();

            //search by director
            Console.WriteLine("\nSEARCH MOVIES BY DIRECTOR (James Cameron):");
            movieList.SearchMovieByDirector("James Cameron");

            //search by rating
            Console.WriteLine("\nSEARCH MOVIES BY RATING (8.6):");
            movieList.SearchMovieByRating(8.6);

            //update rating
            Console.WriteLine("\nUPDATING RATING OF 'Avatar':");
            movieList.UpdateRating("Avatar", 8.0);

            Console.WriteLine("\nMOVIES AFTER RATING UPDATE:");
            movieList.DisplayForward();

            //display in reverse order
            Console.WriteLine("\nDISPLAY MOVIES IN REVERSE ORDER:");
            movieList.DisplayReverse();

            //remove a movie
            Console.WriteLine("\nREMOVING MOVIE 'Titanic':");
            movieList.RemoveMovie("Titanic");

            Console.WriteLine("\nMOVIES AFTER REMOVAL:");
            movieList.DisplayForward();
        }
    }
}
