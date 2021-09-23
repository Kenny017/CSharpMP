using System;
using System.Collections.Generic;

namespace StudentRegistration
{
    class App
    {
        static void main(string[] args)
        {
            Student student1 = new Student("Don Alvaro", 10010010, "don@someemail.com", 10002322333,"MI", new DateTime(1980, 5, 5));
            Console.WriteLine(student1);
        }
    }

    class Student
    {
        public Student(string fName, int studID, string email, long ssNum, string address, DateTime birthDay)
        {
            this.Name = fName;
            this.StudentID = studID;
            this.Email = email;
            this.SocialSecurityNumber = ssNum;
            this.Address = address;
            this.Birthday = birthDay;

        }

        public string Name { set; get; }

        public int Age 
        { get {
                int age = 0;
                age = DateTime.Now.Year - Birthday.Year;

                if (DateTime.Now.DayOfYear < Birthday.DayOfYear)
                    age = age - 1;

                return age;
            } }
        public int StudentID {  get; }

        public string Email { set; get; }

        public long SocialSecurityNumber { set; get; }

        public string Address { set; get; }

        public DateTime Birthday { set; get; }

        public override string ToString()
        {
            return $"Name:{Name}\nEmail:{Email}\nStudentID:{StudentID}\nAge:{Age}\nBirthday:{Birthday}\nAddress:{Address}\nSSN:{SocialSecurityNumber}\n\n"; 
        }
    }

    
}
