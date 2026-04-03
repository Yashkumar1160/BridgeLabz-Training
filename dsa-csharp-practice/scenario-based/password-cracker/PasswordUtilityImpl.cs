using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.password_cracker
{
    internal class PasswordUtilityImpl : IPassword 
    {
        //variable to store password
        string password;

        //flag to check if password is found
        bool found = false;

        //char array to store characters
        char[] chars = "abcdefghijklmnopqrstuvwxyz".ToCharArray();


        //method to set password
        public void SetPassword()
        {
            //take password
            Console.WriteLine("\nENTER PASSWORD: ");
            password = Console.ReadLine();

            //update found
            found = false;

            Console.WriteLine("Password Saved");
        }


        //method to start password cracking 
        public void StartPasswordCracking()
        {
            //check if password is set or not
            if (string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Set password first!");
                return;
            }

            char[] attempt = new char[password.Length];
            GeneratePasswords(0, attempt);

        }

        //method to generate passwords and check if it matches
        // recursive backtracking
        public void GeneratePasswords(int index, char[] attempt)
        {
            //if password is found
            if (found)
            {
                return;
            }

            //if length matches
            if (index == attempt.Length)
            {
                //if password matches
                if (new string(attempt) == password)
                {
                    Console.WriteLine("\nPassword Found: " + password);
                    found = true;
                }
                return;
            }

            //add characters and generate passwords
            foreach (char c in chars)
            {
                attempt[index] = c;
                GeneratePasswords(index + 1, attempt);
            }
        }

    }
}
