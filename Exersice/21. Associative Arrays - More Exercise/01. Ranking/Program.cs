namespace Ranking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<string, string> contest = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> students = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of contests")
                {
                    break;
                }

                string[] inputArray = input
                    .Split(":")
                    .ToArray();

                string newContest = inputArray[0];
                string passwordContest = inputArray[1];

                if (!contest.ContainsKey(newContest))
                {
                    contest.Add(newContest, passwordContest);
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of submissions")
                {
                    break;
                }

                string[] token = input
                    .Split("=>")
                    .ToArray();

                string currentContest = token[0];
                string password = token[1];
                string user = token[2];
                int point = int.Parse(token[3]);

                if (contest.ContainsKey(currentContest) && contest[currentContest].Contains(password))
                {
                    if (!students.ContainsKey(user))
                    {
                        students.Add(user, new Dictionary<string, int>());
                        students[user].Add(currentContest, point);
                    }
                    else
                    {
                        if (!students[user].ContainsKey(currentContest))
                        {
                            students[user].Add(currentContest, point);
                        }
                        else
                        {
                            if (students[user][currentContest] < point)
                            {
                                students[user][currentContest] = point;
                            }
                        }
                    }
                }
            }

            Dictionary<string, int> totalPointOfStudents = new Dictionary<string, int>();

            foreach (var student in students)
            {
                totalPointOfStudents[student.Key] = student.Value.Values.Sum();
            }

            int bestPoint = 0;
            string bestStudent = string.Empty;

            foreach (var student in totalPointOfStudents.OrderByDescending(x => x.Value))
            {
                if (bestPoint < student.Value)
                {
                    bestStudent = student.Key;
                    bestPoint = student.Value;
                }
            }

            Console.WriteLine($"Best candidate is {bestStudent} with total {bestPoint} points.");
            Console.WriteLine("Ranking: ");

            foreach (var student in students.OrderBy(x => x.Key).ThenBy(x => x.Value.Values))
            {
                Console.WriteLine($"{student.Key}");

                foreach (var item in student.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }
    }
}
