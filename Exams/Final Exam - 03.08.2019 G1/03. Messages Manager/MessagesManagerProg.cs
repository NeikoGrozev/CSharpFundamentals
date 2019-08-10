namespace MessagesManager
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MessagesManagerProg
    {
        static void Main()
        {
            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();

            int capacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Statistics")
                {
                    break;
                }

                string[] token = input
                    .Split("=");

                string commnad = token[0];

                if (commnad == "Add")
                {
                    string name = token[1];
                    int send = int.Parse(token[2]);
                    int reseived = int.Parse(token[3]);

                    if (!dict.ContainsKey(name))
                    {
                        dict.Add(name, new List<int>());
                        dict[name].Add(send);
                        dict[name].Add(reseived);
                    }
                }
                else if (commnad == "Message")
                {
                    string sender = token[1];
                    string receiver = token[2];

                    if (dict.ContainsKey(sender) && dict.ContainsKey(receiver))
                    {
                        if (dict[sender].Sum() + 1 >= capacity)
                        {
                            dict.Remove(sender);
                            Console.WriteLine($"{sender} reached the capacity!");
                        }
                        else
                        {
                            dict[sender][0] += 1;
                        }

                        if (dict[receiver].Sum() + 1 >= capacity)
                        {
                            dict.Remove(receiver);
                            Console.WriteLine($"{receiver} reached the capacity!");
                        }
                        else
                        {
                            dict[receiver][1] += 1;
                        }
                    }
                }
                else if (commnad == "Empty")
                {
                    string user = token[1];

                    if (user == "All")
                    {
                        dict = new Dictionary<string, List<int>>();
                    }
                    else
                    {
                        dict.Remove(user);
                    }
                }
            }

            Console.WriteLine($"Users count: {dict.Count}");

            foreach (var item in dict.OrderByDescending(x => x.Value[1]).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value.Sum()}");
            }
        }
    }
}
