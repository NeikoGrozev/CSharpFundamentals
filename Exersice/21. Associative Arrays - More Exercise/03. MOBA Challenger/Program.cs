namespace MOBAChallenger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Season end")
                {
                    break;
                }

                if (command.Contains("->"))
                {
                    string[] user = command
                        .Split(" -> ");

                    string player = user[0];
                    string position = user[1];
                    int skill = int.Parse(user[2]);

                    if (!dict.ContainsKey(player))
                    {
                        dict.Add(player, new Dictionary<string, int>());
                        dict[player].Add(position, skill);
                    }
                    else
                    {
                        if (!dict[player].ContainsKey(position))
                        {
                            dict[player].Add(position, skill);
                        }
                        else
                        {
                            if (dict[player][position] < skill)
                            {
                                dict[player][position] = skill;
                            }
                        }
                    }
                }
                else if (command.Contains("vs"))
                {
                    string[] duel = command
                        .Split(" vs ");

                    string firstPlayer = duel[0];
                    string secondPlayer = duel[1];

                    bool foundFirstPlayer = false;
                    bool foundSecondPlayer = false;

                    if (dict.ContainsKey(firstPlayer))
                    {
                        foundFirstPlayer = true;
                    }

                    if (dict.ContainsKey(secondPlayer))
                    {
                        foundSecondPlayer = true;
                    }

                    if (foundFirstPlayer && foundSecondPlayer)
                    {
                        int sumFirstPlayer = dict[firstPlayer].Values.Sum();
                        int sumSecondPlayer = dict[secondPlayer].Values.Sum();
                        
                        foreach (var positionFirst in dict[firstPlayer])
                        {
                            bool demoted = false;

                            foreach (var positionSecond in dict[secondPlayer])
                            {
                                if (positionFirst.Key == positionSecond.Key)
                                {
                                    if (sumFirstPlayer > sumSecondPlayer)
                                    {
                                        dict.Remove(secondPlayer);
                                        demoted = true;
                                        break;
                                    }
                                    else if (sumFirstPlayer < sumSecondPlayer)
                                    {
                                        dict.Remove(firstPlayer);
                                        demoted = true;
                                        break;
                                    }
                                }
                            }

                            if (demoted)
                            {
                                break;
                            }
                        }
                    }
                }
            }

            foreach (var player in dict.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");

                foreach (var position in player.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }
        }
    }
}
