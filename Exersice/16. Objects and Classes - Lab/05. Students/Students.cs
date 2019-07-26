using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Students
    {
        static void Main()
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                string[] text = Console.ReadLine()
                    .Split(' ')
                    .ToArray();

                if (text[0] == "end")
                {
                    break;
                }

                string firstName = text[0];
                string lastName = text[1];
                string age = text[2];
                string city = text[3];

                Student newstudent = new Student(firstName, lastName, age, city);

                students.Add(newstudent);
            }

            string fromCity = Console.ReadLine();

            foreach (var student in students)
            {
                if (fromCity == student.City)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, string age, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Age { get; set; }

        public string City { get; set; }
    }
}
