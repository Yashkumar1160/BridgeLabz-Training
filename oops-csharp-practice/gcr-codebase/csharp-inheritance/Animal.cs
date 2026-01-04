using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_inheritance
{
    //base class Animal
    internal class Animal
    {
        //protected variables 
        protected string name;

        protected int age;

        //parameterized constructor
        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("ANIMAL MAKES A SOUND");
        }
    }

    //derived class Dog 
    class Dog : Animal
    {
        //parameterized constructor
        public Dog(string name, int age) : base(name, age) { }

        //override MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine("DOG BARKS");
        }
    }

    //derived class Cat
    class Cat : Animal
    {
        //parameterized constructor
        public Cat(string name, int age) : base(name, age) { }

        //override MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine("CAT MEOWS");
        }
    }

    //derived class Bird
    class Bird : Animal
    {
        //parameterized constructor
        public Bird(string name, int age) : base(name, age) { }

        //override MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine("BIRD CHIRPS");
        }
    }

    //class containing Main method
    class Program
    {
        public static void Main(string[] args)
        {
            //call TakeInputs method
            TakeInputs();
        }


        //method to take inputs from user
        public static void TakeInputs()
        {
            //take dog name input
            Console.WriteLine("ENTER DOG NAME: ");
            string dogName = Console.ReadLine();

            //take dog age input
            Console.WriteLine("ENTER DOG AGE: ");
            int dogAge = Convert.ToInt32(Console.ReadLine());

            //create object of Dog class
            Animal dog = new Dog(dogName, dogAge);
            
            //call MakeSound method
            dog.MakeSound();

            //take cat name input
            Console.WriteLine("\nENTER CAT NAME: ");
            string catName = Console.ReadLine();

            //take cat age input
            Console.WriteLine("ENTER CAT AGE: ");
            int catAge = Convert.ToInt32(Console.ReadLine());

            //create object of Cat class
            Animal cat = new Cat(catName, catAge);
            
            //call MakeSound method
            cat.MakeSound();


            //take bird name input
            Console.WriteLine("\nENTER BIRD NAME: ");
            string birdName = Console.ReadLine();

            //take bird age input
            Console.WriteLine("ENTER BIRD AGE: ");
            int birdAge = Convert.ToInt32(Console.ReadLine());

            //create object of Bird class
            Animal bird = new Bird(birdName, birdAge);

            //call MakeSound method
            bird.MakeSound();
        }
    }

}
