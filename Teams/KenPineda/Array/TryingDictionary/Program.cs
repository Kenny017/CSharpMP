using System;
using System.Collections.Generic;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

            // TODO: ASK USER TO INPUT ID, NAME AND GRADE
            // TODO: USE TRY CATCH TO CATCH ERROR ABOUT GETING ID
            // TODO: ADD MORE SIMULATION LATER ON

            Student student1 = new Student()
            {
                ID = 001,
                Name = "Kenneth",
                Grade = 90

            };
            Student student2 = new Student()
            {
                ID = 002,
                Name = "Ken",
                Grade = 88

            };

            Dictionary <int, Student> StudentDictionary = new Dictionary<int, Student>();
            StudentDictionary.Add(student1.ID, student1);
            StudentDictionary.Add(student2.ID, student2);

            Student student001 = StudentDictionary[001];

            foreach(KeyValuePair<int, Student> studentKeyValuePair in StudentDictionary)
            {
                Student stud = studentKeyValuePair.Value;
                 Console.WriteLine("__________________________________\n");
                Console.WriteLine("ID = {0}, Name = {1}, Grade = {2}", stud.ID, stud.Name, stud.Grade);
                Console.WriteLine("__________________________________\n");
            }

        }
    }
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }

    }

}
