namespace SoftUniExamResults
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> exam = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> submission = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "exam finished")
                {
                    break;
                }

                string[] command = input
                    .Split("-")
                    .ToArray();

                string userName = command[0];
                string language = command[1];

                if (language == "banned")
                {
                    exam[userName].Clear();
                    exam.Remove(userName);
                    continue;
                }

                int point = int.Parse(command[2]);

                if (!exam.ContainsKey(userName))
                {
                    exam.Add(userName, new Dictionary<string, int>());
                    exam[userName].Add(language, point);
                }
                else if (exam.ContainsKey(userName))
                {
                    if (exam[userName].ContainsKey(language))
                    {
                        if (exam[userName][language] < point)
                        {
                            exam[userName][language] = point;
                        }
                    }
                    else
                    {
                        exam[userName].Add(language, point);
                    }
                }

                if (!submission.ContainsKey(language))
                {
                    submission.Add(language, 0);
                }

                submission[language]++;
            }

            Console.WriteLine("Results:");

            foreach (var item in exam.OrderByDescending(x => x.Value.Values.First()).ThenBy(x => x.Key))
            {
                foreach (var test in item.Value)
                {
                    Console.WriteLine($"{item.Key} | {test.Value}");
                }
            }

            Console.WriteLine("Submissions:");

            foreach (var item in submission.OrderBy(x => x.Key).ThenBy(x => x.Value))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
