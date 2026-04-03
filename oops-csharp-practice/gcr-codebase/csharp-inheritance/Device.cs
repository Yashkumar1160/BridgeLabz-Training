using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_inheritance
{
    //base class Device
    internal class Device
    {
        //protected variables
        protected string deviceId;

        protected string status;

        //parameterized constructor
        public Device(string deviceId, string status)
        {
            this.deviceId = deviceId;
            this.status = status;
        }

        //method to display device details 
        public virtual void DisplayStatus()
        {
            Console.WriteLine("DEVICE ID: " + deviceId);
            Console.WriteLine("DEVICE STATUS: " + status);
        }
    }

    //derived class Thermostat
    class Thermostat : Device
    {
        //private variable
        int temperatureSetting;

        //parameterized constructor
        public Thermostat(string deviceId, string status, int temperatureSetting) : base(deviceId, status)
        {
            this.temperatureSetting = temperatureSetting;
        }

        //override DisplayStatus method
        public override void DisplayStatus()
        {
            //call base class DisplayStatus method
            base.DisplayStatus();

            Console.WriteLine("TEMPERATURE: " + temperatureSetting);
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

        //method to take user inputs
        public static void TakeInputs()
        {
            //take device id input
            Console.Write("ENTER DEVICE ID: ");
            string id = Console.ReadLine();

            //take device status input
            Console.Write("ENTER DEVICE STATUS: ");
            string status = Console.ReadLine();

            //take temperature setting input
            Console.Write("ENTER TEMPERATURE SETTING: ");
            int temperatureSetting = Convert.ToInt32(Console.ReadLine());

            //create object of Thermostat class
            Device device = new Thermostat(id, status, temperatureSetting);

            //call DisplayStatus method to display device details
            Console.WriteLine("\nDEVICE DETAILS: ");

            device.DisplayStatus();


        }
    }
}
