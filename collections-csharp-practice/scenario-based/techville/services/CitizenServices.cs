using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using techville.exceptions;
using techville.modules;
using techville.utilities;
namespace techville.services

{
    public class CitizenServices
    {
        //array to store citizens
        Citizen[] citizens = new Citizen[100];

        //M-3 Smart Citizen Database
        //array to store Citizen IDs
        int[] citizenIds = new int[1000];

        //2D array to store number of citizens in each Zone & Sector
        int[,] zoneSectorCounts = new int[5, 4];

        //variable to generate unique Citizen IDs
        int nextCitizenId = 1;

        //total citizen count
        int totalCitizen = 0;

        //M-1 Method to register citizen
        public void RegisterCitizen()
        {
            //try block
            try
            {
                //check if database is full
                if (totalCitizen >= citizens.Length)
                {
                    throw new DatabaseFullException("Database is Full");
                    return;
                }

                //take name input and validate it 
                string name = InputValidator.GetValidString("Enter Name: ");

                //check duplicate citizens
                for (int i = 0; i < totalCitizen; i++)
                {
                    if (citizens[i].Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                    {
                        throw new DuplicateCitizenException("Citizen already exists.");
                    }
                }

                //take age input and validate it 
                int age = InputValidator.GetValidPositiveInt("Enter Age: ");

                //take income input and validate it 
                double income = InputValidator.GetValidPositiveDouble("Enter Income: ");

                //take years input and validate it 
                int years = InputValidator.GetValidNonNegativeInt("Enter Residency Years: ");

                //M-3 Smart Citizen Database
                //take zone 
                Console.Write("Enter Zone (0-4): ");
                int zone = int.Parse(Console.ReadLine());

                //take citizen sector
                Console.Write("Enter Sector (0-3): ");
                int sector = int.Parse(Console.ReadLine());

                //create citizen object 
                Citizen citizen = new Citizen(name, age, income, years, "");

                //store citizen in array
                citizens[totalCitizen] = citizen;

                //assign and store unique Citizen ID
                citizenIds[totalCitizen] = nextCitizenId++;

                //increase count for specific Zone & Sector
                zoneSectorCounts[zone, sector]++;

                //increase total citizen count
                totalCitizen++;

                Console.WriteLine("Citizen Registered Successfully");
                CalculateEligibility(citizen);
            }
            //catch blocks
            catch(DuplicateCitizenException ex)
            {
                Console.WriteLine("Duplicate Error: " + ex.Message);
            }
            catch(DatabaseFullException ex)
            {
                Console.WriteLine("Database Full Exception: "+ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Caught: " + ex.Message);
            }

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


        //M-3 Method to display number of citizens in each Zone & Sector
        public void DisplayZoneSectorData()
        {
            Console.WriteLine("\n===== Zone & Sector Citizen Count =====");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Zone " + i);

                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Sector " + j + " : " + zoneSectorCounts[i, j] + " citizens");
                }
            }
        }

        //M-3 Method to sort Citizen IDs in ascending order
        public void SortCitizenIds()
        {
            //sorting  array
            Array.Sort(citizenIds, 0, totalCitizen);

            Console.WriteLine("Citizen IDs Sorted Successfully");
        }

        //M-3 Method to search citizen using ID
        public void SearchCitizenById(int id)
        {
            //loop through Citizen IDs
            for (int i = 0; i < totalCitizen; i++)
            {
                if (citizenIds[i] == id)
                {
                    Console.WriteLine("Citizen Found:");
                    Console.WriteLine(citizens[i]);
                    return;
                }
            }

            //if ID not found
            Console.WriteLine("Citizen ID Not Found");
        }
        //M-3 Method to create backup copy of Citizen IDs
        public void CopyCitizenIds()
        {
            //array to store ids
            int[] backupIds = new int[totalCitizen];

            //copy values from original array to backup array
            Array.Copy(citizenIds, backupIds, totalCitizen);

            Console.WriteLine("Citizen IDs copied.");
        }

        //M-4 Method to Update Citizen Profile 
        public void UpdateCitizenProfile(int id)
        {
            for (int i = 0; i < totalCitizen; i++)
            {
                if (citizenIds[i] == id)
                {
                    Citizen citizen = citizens[i];

                    //take new name
                    Console.Write("Enter New Name: ");
                    string newName = InputValidator.FormatName(Console.ReadLine());

                    //take email
                    Console.Write("Enter Email: ");
                    string email = InputValidator.GetValidEmail("Enter Email: ");

                    //take address
                    Console.Write("Enter Address: ");
                    string address = InputValidator.FormatAddress(Console.ReadLine());

                    //update values
                    citizen.Name = newName;
                    citizen.Email = email;
                    citizen.Address = address;

                    Console.WriteLine("Profile Updated Successfully");

                    //call GenerateProfileSummary method
                    Console.WriteLine(GenerateProfileSummary(citizen));
                    return;
                }
            }

            Console.WriteLine("Citizen Not Found");
        }
        //M-4 Method for Pass by Reference Example
        public void IncreaseResidencyYears(ref Citizen citizen)
        {
            citizen.ResidencyYears += 1;
        }

        //M-4 Method to Search Citizen by Name
        public void SearchCitizenByName(string name)
        {
            //flag to check if citizen is found
            bool found = false;

            //loop through citizens
            for (int i = 0; i < totalCitizen; i++)
            {
                //if citizen is found
                if (citizens[i].Name.ToLower().Contains(name.ToLower()))
                {
                    Console.WriteLine("\nCitizen Found:");
                    Console.WriteLine(citizens[i]);
                    found = true;
                }
            }

            //if citizen not found
            if (!found)
                Console.WriteLine("Citizen Not Found");
        }

        //M-4 Method to Generate Profile Summary 
        public string GenerateProfileSummary(Citizen citizen)
        {
            return $"Profile Summary:\n" +
                   $"Name: {citizen.Name}\n" +
                   $"Email: {citizen.Email}\n" +
                   $"Address: {citizen.Address}\n" +
                   $"Service Package: {citizen.ServicePackage}";
        }


    }
}