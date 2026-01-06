using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.bird_sanctuary_system
{
    //abstract class Bird
    abstract class Bird
    {
        //variable to store bird species
        protected string species;

        //variable to store bird color
        protected string color;

        //parameterized constructor
        public Bird(string species,string color)
        {
            this.species = species;
            this.color = color;
        }

        //method to get species
        public string GetSpecies()
        {
            return species;
        }

        //method to get color 
        public string GetColor()
        {
            return color; 
        }

        //abstract method to display bird details
        public abstract void DisplayDetails();

    }
}
