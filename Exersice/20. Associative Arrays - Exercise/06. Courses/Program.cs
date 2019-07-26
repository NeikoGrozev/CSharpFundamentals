namespace _Courses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] student = Console.ReadLine()
                    .Split(" : ")
                    .ToArray();

                if (student[0] == "end")
                {
                    break;
                }
                string course = student[0];
                string studentName = student[1];

                if (!courses.ContainsKey(course))
                {
                    courses.Add(course, new List<string>());
                    courses[course].Add(studentName);
                }
                else
                {
                    courses[course].Add(studentName);
                }
            }

            foreach (var course in courses.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                foreach (var student in course.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
