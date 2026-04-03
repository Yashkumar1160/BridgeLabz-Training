using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.c__methods.level_3
{
    internal class GenerateOTP
    {
        public static void Main(string[] args)
        {
            //create array to store otps
            int[] otps = new int[10];
            //loop to generate otps
            for (int i = 0; i < otps.Length; i++)
            {
                otps[i] = Generate();
                Console.WriteLine("OTP " + (i + 1) + " : " + otps[i]);
            }
            //check all otps are unique or not
            Console.WriteLine("All OTPs unique: " + AreUnique(otps));
        }
        //Method to check unique otps
        public static bool AreUnique(int[] otps)
        {
            //check uniqueness of otps
            for (int i = 0; i < otps.Length; i++)
            {
                for (int j = i + 1; j < otps.Length; j++)
                {
                    if (otps[i] == otps[j])
                    {   //if otps are not unique return false
                        return false;
                    }
                }
            }
            return true;
        }

        //Method to generate otp
        public static int Generate()
        {   //create object of Random class
            Random random = new Random();
            //generate random otp
            return random.Next(100000, 1000000);
        }
    }
}
