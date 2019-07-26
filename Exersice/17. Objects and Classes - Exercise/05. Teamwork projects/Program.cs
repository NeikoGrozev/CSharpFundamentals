using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    class Program
    {
        static void Main()
        {
            int numberOfTeam = int.Parse(Console.ReadLine());
            int counter = 0;
            List<TeamWork> allTeam = new List<TeamWork>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end of assignment")
                {
                    break;
                }

                if (command.Contains("->"))
                {
                    string[] commands = command.Split("->").ToArray();

                    string team = commands[1];
                    string member = commands[0];

                    if (!allTeam.Any(x => x.Team.Contains(team)))
                    {
                        Console.WriteLine($"Team {team} does not exist!");
                    }
                    else if (!allTeam.Any(x => x.Member.Contains(member)) && allTeam.Any(x => x.Team == team) &&
                        !allTeam.Any(x => x.Creator.Contains(member)))
                    {
                        TeamWork existingTeam = allTeam.First(x => x.Team == team);

                        existingTeam.Member.Add(member);
                    }
                    else if (allTeam.Any(x => x.Member.Contains(member)) || allTeam.Any(y => y.Creator.Contains(member)))
                    {
                        Console.WriteLine($"Member {member} cannot join team {team}!");
                    }

                }
                else if (command.Contains("-"))
                {
                    string[] commands = command.Split("-");

                    string team = commands[1];
                    string creator = commands[0];

                    if (counter < numberOfTeam)
                    {
                        if (!allTeam.Any(x => x.Team == team) && !allTeam.Any(x => x.Creator == creator))
                        {
                            TeamWork teamWork = new TeamWork();
                            teamWork.Team = team;
                            teamWork.Creator = creator;

                            allTeam.Add(teamWork);

                            counter++;

                            Console.WriteLine($"Team {team} has been created by {creator}!");
                            continue;
                        }
                    }

                    if (allTeam.Any(x => x.Creator == creator))
                    {
                        Console.WriteLine($"{creator} cannot create another team!");
                        
                    }
                    else if (allTeam.Any(x => x.Team == team))
                    {
                        Console.WriteLine($"Team {team} was already created!");
                    }
                }
            }

            List<TeamWork> emptyMembers = new List<TeamWork>();

            for (int i = 0; i < allTeam.Count; i++)
            {
                if (allTeam[i].Member.Count == 0)
                {
                    emptyMembers.Add(allTeam[i]);
                    allTeam.RemoveAt(i);
                    i--;
                }
            }

            foreach (TeamWork team in allTeam.OrderByDescending(x => x.Member.Count).ThenBy(x => x.Team))
            {
                Console.WriteLine($"{team.Team}");

                Console.WriteLine($"- {team.Creator}");

                foreach (var member in team.Member.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var team in emptyMembers.OrderBy(x => x.Team))
            {
                Console.WriteLine($"{team.Team}");
            }
        }
    }

    class TeamWork
    {
        public string Team { get; set; }
        public string Creator { get; set; }

        public List<string> Member = new List<string>();
    }
}
