using System;
using System.Collections.Generic;

namespace StudentManagementSystem
{
    class Program
    {
        static Dictionary<int, Student> listDictionary = new Dictionary<int, Student>();
        static void Main(string[] args)
        {
            while (true)
            {
                
                Console.WriteLine("+----------------------------+");
                Console.WriteLine("| STUDENTS MANAGEMENT SYSTEM |");
                Console.WriteLine("+----------------------------+");
                Console.WriteLine("|1. Insert new Student       |");
                Console.WriteLine("|2. View list of Students    |");
                Console.WriteLine("|3. Search Students          |");
                Console.WriteLine("|4. Exit                     |");
                Console.WriteLine("+----------------------------+");
                
                Console.Write("Your choice: ");
                try
                {
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        // if user choose 1 it will call the IStudent class
                        case 1:
                            InsertStudent();
                            break;
                        case 2:
                            ViewList();
                            break;
                        case 3:
                            Search();
                            break;
                        case 4:
                            System.Environment.Exit(0);
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong Input.Try again.\n"); 
                }
                    
            }
        }

        private static void Search()
        {
            bool found = false;
            Console.Write("Input Class: ");
            String search = Console.ReadLine();
            Console.WriteLine("All student of class " + search);
            foreach (Student student in listDictionary.Values)
            {
                if (student.Class.Equals(search))
                //if (String.Compare(student.Class, search, true) == 0)
                {
                    Console.WriteLine("----------------------------");
                    student.Display();
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("No students were found!");
            }
        }

        private static void ViewList()
        {
            foreach (Student i in listDictionary.Values)
            {
                Console.WriteLine("----------------------------");
                i.Display();
            }
            Console.WriteLine($"No. of Students: {Student.Count}");
        }

        private static void InsertStudent()
        {
            Student student = new Student();        //DAL, if possible, validating all inputs before
                                                    //the creation of the object.
            //Increament ID
            student.ID = Student.Count;

            //Input name
            Console.Write("Enter Fullname: ");
            student.FullName = Console.ReadLine();

            //Input date
            while (true)
            {
                Console.Write("Enter Date of Birth: Ex. (01/01/2021) : "); 
                //DateTime dDate;
                try
                {
                    student.DateofBirth = DateTime.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("The date is not in the correct format!");
                    Console.WriteLine(ex.Message);
                }
            }

            //Input Nationality
            Console.Write("Enter Nationality: ");
            student.Nationality = Console.ReadLine();

            //Input Class
            Console.Write("Enter Class: ");
            student.Class = Console.ReadLine();

            //Input Mobile
            while (true)
            {
                Console.Write("Enter Mobile: ");
                try
                {
                    student.Mobile = Console.ReadLine();
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("The number is not in the correct format!");
                    Console.WriteLine(ex.Message);
                }
            }

            listDictionary.Add(student.ID, student);
            Console.WriteLine("Successfully inserted a student!");
        }
    }
}



