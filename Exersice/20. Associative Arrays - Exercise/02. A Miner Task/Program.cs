namespace AMinerTask
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            while (true)
            {
                string resorce = Console.ReadLine();

                if (resorce == "stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

                if (dict.ContainsKey(resorce))
                {
                    dict[resorce] += quantity;
                }
                else
                {
                    dict.Add(resorce, quantity);
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
