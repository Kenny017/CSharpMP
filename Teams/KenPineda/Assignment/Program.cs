using System;
using System.Collections.Generic;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string FName, LName, MName, dateofbirth, street, city, province;
            char gender;
            

            List<Person> Persons = new List<Person>();

            for(var i = 1; i <= 3; i++){

            Console.WriteLine("What is your First name?");
            FName = Console.ReadLine();
            
            Console.WriteLine("What is your Last name?");
            LName = Console.ReadLine();

            Console.WriteLine("What is your Middle name?");
            MName = Console.ReadLine();

            Console.WriteLine("What is your Date of Birth?");
            dateofbirth = Console.ReadLine();

            Console.WriteLine("What is your Gender?");
            gender = Console.ReadLine().ToString()[0];

            Console.WriteLine("What is you City?");
            city = Console.ReadLine();

            Console.WriteLine("What is your Street?");
            street = Console.ReadLine();

            Console.WriteLine("What is your Province?");
            province = Console.ReadLine();

            var address = new Address(city, street, province);
            var person = new Person(FName, LName, MName, dateofbirth, gender, address);
            Persons.Add(person);
            }
            foreach(var person in Persons){

            Console.WriteLine($"{person.Fname}");
        }
            Console.WriteLine("What is your City?");
            city = Console.ReadLine();

            Console.WriteLine("What is your Street?");
            street = Console.ReadLine();

            Console.WriteLine("What is your Province?");
            province = Console.ReadLine();

            var address2 = new Address(city, street, province);
            Persons[1].PersonAddress[0] = address2;

            Console.WriteLine("Index 2 new Address");
            Console.WriteLine(address2.ToString());

            Persons.RemoveAt(Persons.Count-1);

            foreach(var person in Persons){

            Console.WriteLine($"{person.Fname}");
        }
        
    }

}
        class Person
        {
            public string Fname {get; set;}
            public string Lname {get; set;}
            public string Mname {get; set;}
            public string DateOfBirth {get; set;}
            public char Gender{get; set;}
            public List<Address> PersonAddress = new List<Address>();
            public Person(string fname, string lname, string mname, string dateofbirth, char gender, Address address ){
                Fname = fname;
                Lname = lname;
                mname = Mname;
                dateofbirth = DateOfBirth;
                gender = Gender;
                PersonAddress.Add(address);
            }

        }
        class Address
        {           
            public string City;
            public string Street;    
            public string Province;
            public Address(string city, string street, string province){

                City = city;
                Street = street;
                Province = province;
            }

            public override string ToString(){

                return $"{City}, {Street}, {Province}";
            }
        }
}
