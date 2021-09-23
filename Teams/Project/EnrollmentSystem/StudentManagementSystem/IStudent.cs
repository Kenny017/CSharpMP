using System;

namespace StudentManagementSystem
{
    interface IStudent
    {
        int ID
        {
            get;
            set;
        }

        string FullName
        {
            get;
            set;
        }

        DateTime DateofBirth
        {
            get;
            set;
        }

        string Nationality
        {
            get;
            set;
        }

        string Class
        {
            get;
            set;
        }

       
        string Mobile
        {
            get;
            set;
        }

        void Display();
    }
}
