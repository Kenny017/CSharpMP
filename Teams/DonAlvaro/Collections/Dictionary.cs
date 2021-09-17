using System;
using System.Collections.Generic;

namespace Collection
{
    class DictionaryProgram
    {
        //You are given a phone book that consists of people's names and their phone number. 
        //After that you will be given some person's name
        //as query. For each, query, print the phone number of the person.
        //Input Format: The first line will have an integer N denoting the
        // number of entries in the phone book. Each entry consists of two lines:
        //a name and a corresponding phone number. After these, there will be some queries. 
        //Each query will contain a person's name. 
        //Constraints: person's name consists only of lower-case English letters and it may 
        //be in the format 'first-name' 'last-name' or in the format
        //'first-name //Each phone number has exactly 8 digits without any leading zeros.
        //
        static void main(string[] args)
        {
            Console.Write("Number of Entries: ");
            int entries = int.Parse(Console.ReadLine());
            Dictionary<string, string> PhoneBook = new Dictionary<string, string>();
            string name = "";
            string phoneNumber = "";

            for (int i = 0; i < entries; i++)
            {
                Console.WriteLine($"Entry No. {i+1}");
                Console.Write("Enter name: ");
                name = Console.ReadLine();

                Console.Write("Enter number: ");
                phoneNumber = Console.ReadLine().TrimStart('0');
                try
                {
                    PhoneBook.Add(name.ToLower(), phoneNumber.Substring(0, 8));
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("That Name is already on the Phonebook.");
                }
            }
            Console.Write("Enter number of Queries: ");
            int numOfQuery = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfQuery; i++)
            {
                Console.Write("Enter Name to get phone: ");
                string lookUpName = Console.ReadLine();
                try
                {
                    string lookUpPhoneNumber = PhoneBook[lookUpName.ToLower()];
                    Console.WriteLine($"Name: {lookUpName}, Number: {lookUpPhoneNumber}");
                }
                catch (KeyNotFoundException)
                {
                    Console.WriteLine("That Name didn't exist.");

                }
            }

        }

    }

}