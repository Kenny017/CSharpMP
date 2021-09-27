using System;
using System.Collections.Generic;

namespace ProjectTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname, lname, mname, dateOfBirth, StreetAddress, City, Province;
            char Gender;
            Address address;

            List<Person> ListOfPersons = new List<Person>();

            for (int i = 0; i < 3; i++)
            {

                Console.Write("\nEnter first name: ");
                fname = Console.ReadLine();

                Console.Write("Enter middle name: ");
                mname = Console.ReadLine();

                Console.Write("Enter last name: ");
                lname = Console.ReadLine();

                Console.Write("Enter Gender(M/F): ");
                Gender = Console.ReadLine().ToString()[0];

                Console.Write("Enter Date of Birth: ");
                dateOfBirth = DateTime.Parse(Console.ReadLine()).ToString();

                Console.WriteLine("\nAddress");
                Console.Write("Input Street Address: ");
                StreetAddress = Console.ReadLine();
                Console.Write("Input City: ");
                City = Console.ReadLine();
                Console.Write("Input Province: ");
                Province = Console.ReadLine();

                address = new Address(StreetAddress, City, Province);

                Person person = new Person(fname, lname, mname, Gender, dateOfBirth, address);

                ListOfPersons.Add(person);
            }

            for (int i = 0; i < ListOfPersons.Count; i++)
            {
                Console.WriteLine($"\nPRINTING PERSON {i+1}");
                Console.WriteLine(ListOfPersons[i].ToString());
            }
            
            Console.Write("\nInput Street Address(index 2): ");
            StreetAddress = Console.ReadLine();
            Console.Write("Input City(index 2): ");
            City = Console.ReadLine();
            Console.Write("Input Province(index 2): ");
            Province = Console.ReadLine();

            address = new Address(StreetAddress, City, Province);

            //Set to index 1, assuming starting at 0-index //UPDATING 2nd Index
            ListOfPersons[1].PersonAddressList[0] = address;

            Console.WriteLine(ListOfPersons[1]); //Printing 2nd Index

            ListOfPersons.RemoveAt(ListOfPersons.Count - 1); // Removing 3rd Index

        }
    }

    public class Person
    {
        public List<Address> PersonAddressList = new List<Address>();
        public Person(string fname, string lname, string mname, char gender, string dateOfBirth, Address address)
        {
            Fname = fname;
            Lname = lname;
            Mname = mname;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            PersonAddressList.Add(address);
        }
        public string Fname { get; private set; }
        public string Lname { get; private set; }
        public string Mname { get; private set; }
        public string DateOfBirth { get; private set; }

        public char Gender { get; private set; }

        public override string ToString()
        {
            return "\nFName: " + Fname + "\nMName: " + Mname + "\nLName: " + Lname + 
                "\nGender: "+ Gender +"\nDate of Birth: " + DateOfBirth + PersonAddressList[0].ToString();
        }

    }

    public class Address
    {
        public Address(string street, string city, string province)
        {
            Street = street;
            City = city;
            Province = province;

        }
        public string Street { get;  set; }

        public string City { get;  set; }

        public string Province { get;  set; }

        public override string ToString()
        {
            return "\nStreet: " + Street + "\nCity: " + City + "\nProvince: " + Province;
        }
    }
}
