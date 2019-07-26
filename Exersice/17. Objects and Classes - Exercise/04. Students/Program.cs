using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            List<Student> allStudent = new List<Student>();

            for (int i = 0; i < num; i++)
            {
                string[] date = Console.ReadLine()
                    .Split(" ");

                string firstName = date[0];
                string lastName = date[1];
                double grade = double.Parse(date[2]);

                Student student = new Student(firstName, lastName, grade);

                allStudent.Add(student);
            }
                       
            List<Student> sortStudent = new List<Student>();

            sortStudent = allStudent.OrderByDescending(x => x.Grade).ToList();

            foreach (Student student in sortStudent)
            {
                Console.WriteLine(student);
            }                
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Student(string firtsName, string lastName, double grade)
        {
            this.FirstName = firtsName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade:F2}";
        }
    }
}
