namespace Judge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> judge = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> individualStandings = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "no more time")
                {
                    break;
                }

                string[] currentInput = input
                    .Split(" -> ")
                    .ToArray();

                string student = currentInput[0];
                string contest = currentInput[1];
                int point = int.Parse(currentInput[2]);

                if (!judge.ContainsKey(contest))
                {
                    judge.Add(contest, new Dictionary<string, int>());
                    judge[contest].Add(student, point);
                }
                else
                {
                    if (!judge[contest].ContainsKey(student))
                    {
                        judge[contest].Add(student, point);
                    }
                    else
                    {
                        if (judge[contest][student] < point)
                        {
                            judge[contest][student] = point;
                        }
                    }
                }
            }

            foreach (var contest in judge)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");
                int counter = 1;

                foreach (var student in contest.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{counter++}. {student.Key} <::> {student.Value}");

                    if (!individualStandings.ContainsKey(student.Key))
                    {
                        individualStandings.Add(student.Key, student.Value);
                    }
                    else
                    {
                        individualStandings[student.Key] += student.Value;
                    }
                }
            }

            Console.WriteLine("Individual standings:");

            int newCounter = 1;

            foreach (var student in individualStandings.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{newCounter++}. {student.Key} -> {student.Value}");
            }
        }
    }
}
