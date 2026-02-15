using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using techville.modules;
using techville.utilities;
namespace techville.services

{
    public class CitizenServices
    {
        //array to store citizens
        Citizen[] citizens = new Citizen[100];

        //total citizen count
        int totalCitizen = 0;

        //M-1 Method to register citizen
        public void RegisterCitizen()
        {
            //take name input and validate it 
            string name = InputValidator.GetValidString("Enter Name: ");

            //take age input and validate it 
            int age = InputValidator.GetValidPositiveInt("Enter Age: ");

            //take income input and validate it 
            double income = InputValidator.GetValidPositiveDouble("Enter Income: ");

            //take years input and validate it 
            int years = InputValidator.GetValidNonNegativeInt("Enter Residency Years: ");


            //create citizen object 
            Citizen citizen = new Citizen(name, age, income, years, "");

            //add citizen
            citizens[totalCitizen++] = citizen;

            Console.WriteLine("Citizen Registered Successfully");
            CalculateEligibility(citizen);
        }

        //M-1 Method to calculate eligibility score 
        public void CalculateEligibility(Citizen citizen)
        {
            //variables to store scores
            int ageScore;
            int incomeScore;
            int residencyScore = citizen.ResidencyYears * 5;

            //variables to check if citizen's eligibility
            bool eligibleForHealthcare = false;
            bool eligibleForSubsidy = false;
            bool eligibleForVoting = citizen.Age >= 18;


            //check citizen age and find score
            if (citizen.Age >= 60)
            {
                ageScore = 30;
                eligibleForHealthcare = true;

            }
            else if (citizen.Age >= 18)
            {
                ageScore = 10;
            }
            else
            {
                ageScore = 0;
            }

            //check citizen income and find score
            if (citizen.Income <= 30000)
            {
                incomeScore = 40;
                eligibleForSubsidy = true;
            }
            else if (citizen.Income <= 70000)
            {
                incomeScore = 20;
            }
            else
            {
                incomeScore = 5;
            }
            int totalScore = ageScore + incomeScore + residencyScore;

            AssignServicePackage(citizen, totalScore);

            //display results
            Console.WriteLine($"Total Score: {ageScore + incomeScore + residencyScore}");
            Console.WriteLine($"Healthcare Scheme : {(eligibleForHealthcare ? "Eligible" : "Not Eligible")}");
            Console.WriteLine($"Income Subsidy    : {(eligibleForSubsidy ? "Eligible" : "Not Eligible")}");
            Console.WriteLine($"Voting Rights     : {(eligibleForVoting ? "Eligible" : "Not Eligible")}");
        }

        //method to check eligibility
        public void CheckAllEligibility()
        {
            if (totalCitizen == 0)
            {
                Console.WriteLine("No Citizens Registered");
                return;
            }

            for (int i = 0; i < totalCitizen; i++)
            {
                Console.WriteLine("\n--------------------------------");
                Console.WriteLine("Citizen: " + citizens[i].Name);
                CalculateEligibility(citizens[i]);
            }
        }

        //M-2 Service Package Checker 
        //method to assign service package
        public void AssignServicePackage(Citizen citizen, int score)
        {
            //check score
            if (score < 30)
            {
                citizen.ServicePackage = "Not Eligible";
                return;
            }

            //assign package accordingly
            if (score >= 80)
                citizen.ServicePackage = "Platinum";
            else if (score >= 60)
                citizen.ServicePackage = "Gold";
            else if (score >= 40)
                citizen.ServicePackage = "Silver";
            else
                citizen.ServicePackage = "Basic";
        }



        //method to display all registered citizens
        public void DisplayAllCitizens()
        {
            //if no citizen data exists
            if (totalCitizen == 0)
            {
                Console.WriteLine("No Citizens Registered");
                return;
            }

            Console.WriteLine("\n===== All Registered Citizens =====");

            for (int i = 0; i < totalCitizen; i++)
            {
                Console.WriteLine(citizens[i]);
            }
        }


    }
}