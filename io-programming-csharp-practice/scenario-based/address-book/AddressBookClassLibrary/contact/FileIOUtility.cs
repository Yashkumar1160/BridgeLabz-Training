using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json; 
using BridgeLabzTraining.collections_csharp_practice.scenario_based.address_book.AddressBookClassLibrary.addressbookfolder;
using BridgeLabzTraining.collections_csharp_practice.scenario_based.address_book.AddressBookClassLibrary.contact;


namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.address_book.AddressBookClassLibrary.contact
{
    internal static class FileIOUtility
    {
        //method to write contacts to text file
        public static void WriteToTextFile(string filePath, List<Contact> contacts)
        {
            using StreamWriter writer = new StreamWriter(filePath);
            foreach (var contact in contacts)
            {
                writer.WriteLine(contact.ToString());
            }
        }

        //method to read contacts from text file
        public static void ReadFromTextFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File does not exist.");
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }

       //method to write contacts to csv file
        public static void WriteToCSV(string filePath, List<Contact> contacts)
        {
            using StreamWriter writer = new StreamWriter(filePath);
            // Header
            writer.WriteLine("FirstName,LastName,Address,City,State,Zip,Email,PhoneNumber");

            foreach (var c in contacts)
            {
                writer.WriteLine($"{c.FirstName},{c.LastName},{c.Address},{c.City},{c.State},{c.Zip},{c.Email},{c.PhoneNumber}");
            }
        }

        //method to read contacts from text file
        public static void ReadFromCSV(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("CSV file does not exist.");
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }

        //method to write contacts to json file
        public static void WriteToJSON(string filePath, List<Contact> contacts)
        {
            string json = JsonSerializer.Serialize(contacts, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        //method to read contacts from json file
        public static void ReadFromJSON(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("JSON file does not exist.");
                return;
            }

            string json = File.ReadAllText(filePath);
            var contacts = JsonSerializer.Deserialize<List<Contact>>(json);
            foreach (var c in contacts)
            {
                Console.WriteLine(c);
            }
        }
    }
}
