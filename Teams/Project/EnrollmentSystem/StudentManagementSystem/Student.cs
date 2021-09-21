using System;

namespace StudentManagementSystem
{
    class Student : IStudent
    {
        string ClassName;
        public string Class
        {
            get
            {
                return ClassName;
            }

            set
            {
                ClassName = value;
            }
        }

        DateTime dateofBirth;
        public DateTime DateofBirth
        {
            get
            {
                return dateofBirth;
            }

            set
            {
                dateofBirth = value;
            }
        }

        string fullName;
        public string FullName
        {
            get
            {
                return fullName;
            }

            set
            {
                fullName = value;
            }
        }

        int id;
        public int ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        string mobile;
        public string Mobile
        {
            get
            {
                return mobile;
            }

            set
            {
                mobile = value;
            }
        }

        string nationality;
        public string Nationality
        {
            get
            {
                return nationality;
            }

            set
            {
                nationality = value;
            }
        }

       

        public void Display()
        {
            Console.WriteLine("Full Name: " + FullName);
            Console.WriteLine("Date of Birth: " + DateofBirth.ToString("dd/MM/yyyy"));
            Console.WriteLine("Native: " + Nationality);
            Console.WriteLine("Class: " + Class);
            Console.WriteLine("Mobile : " + Mobile);
        }
    }
}