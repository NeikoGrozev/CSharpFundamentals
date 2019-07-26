using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniCoursePlanning
{
    class SoftUniCoursePlanning
    {
        static void Main()
        {
            List<string> courses = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(":")
                    .ToArray();

                if (command[0] == "course start")
                {
                    for (int i = 0; i < courses.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}.{courses[i]}");
                    }

                    break;
                }

                switch (command[0])
                {
                    case "Add":
                        Add(courses, command[1]);
                        break;
                    case "Insert":
                        Insert(courses, command[1], int.Parse(command[2]));
                        break;
                    case "Remove":
                        Remove(courses, command[1]);
                        break;
                    case "Swap":
                        Swap(courses, command[1], command[2]);
                        break;
                    case "Exercise":
                        Exercise(courses, command[1]);
                        break;
                }
            }
        }

        private static void Add(List<string> courses, string lesssonTitle)
        {
            if (!courses.Contains(lesssonTitle))
            {
                courses.Add(lesssonTitle);
            }
        }

        private static void Insert(List<string> courses, string lesssonTitle, int index)
        {
            if (!courses.Contains(lesssonTitle) && index >= 0 && index <= courses.Count - 1)
            {
                courses.Insert(index, lesssonTitle);
            }
        }

        private static void Remove(List<string> courses, string lesssonTitle)
        {
            if (courses.Contains(lesssonTitle))
            {
                courses.Remove(lesssonTitle);

                if (courses.Contains(lesssonTitle + "-Exercise"))
                {
                    courses.Remove(lesssonTitle + "-Exercise");
                }
            }
        }

        private static void Swap(List<string> courses, string firstLesssonTitle, string secondLesssonTitle)
        {
            int firstIndex = -1;
            int secondIndex = -1;
            bool isFirstIndex = false;
            bool isSecondIndex = false;


            if (courses.Contains(firstLesssonTitle))
            {
                firstIndex = courses.IndexOf(firstLesssonTitle);
                isFirstIndex = true;
            }

            if (courses.Contains(secondLesssonTitle))
            {
                secondIndex = courses.IndexOf(secondLesssonTitle);
                isSecondIndex = true;
            }

            if (isFirstIndex && isSecondIndex)
            {
                string temp = firstLesssonTitle;
                courses[firstIndex] = secondLesssonTitle;
                courses[secondIndex] = temp;

                if (firstIndex + 1 <= courses.Count - 1 && courses[firstIndex + 1] == $"{firstLesssonTitle}-Exercise")
                {
                    courses.RemoveAt(firstIndex + 1);
                    firstIndex = courses.IndexOf(firstLesssonTitle);
                    courses.Insert(firstIndex + 1, $"{firstLesssonTitle}-Exercise");
                }

                if (secondIndex + 1 <= courses.Count - 1 && courses[secondIndex + 1] == $"{secondLesssonTitle}-Exercise")
                {
                    courses.RemoveAt(secondIndex + 1);
                    secondIndex = courses.IndexOf(secondLesssonTitle);
                    courses.Insert(secondIndex + 1, $"{secondLesssonTitle}-Exercise");
                }
            }
        }

        private static void Exercise(List<string> courses, string lessonTitle)
        {
            if (courses.Contains(lessonTitle) && !courses.Contains($"{lessonTitle}-Exercise"))
            {
                int index = courses.IndexOf(lessonTitle);
                courses.Insert(index + 1, $"{lessonTitle}-Exercise");
            }
            else if (!courses.Contains(lessonTitle))
            {
                courses.Add(lessonTitle);
                courses.Add($"{lessonTitle}-Exercise");
            }
        }
    }
}
