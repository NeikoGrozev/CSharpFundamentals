namespace CompanyUsers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            SortedDictionary<string, List<string>> dict = new SortedDictionary<string, List<string>>();

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(" -> ")
                    .ToArray();

                if (command[0] == "End")
                {
                    break;
                }

                string company = command[0];
                string employee = command[1];

                if (!dict.ContainsKey(company))
                {
                    dict.Add(company, new List<string>());
                }

                if (!dict[company].Contains(employee))
                {
                    dict[company].Add(employee);
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}");

                foreach (var employee in item.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
