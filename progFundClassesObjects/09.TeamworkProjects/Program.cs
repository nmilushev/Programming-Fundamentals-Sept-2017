using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _09.TeamworkProjects
{
    class Team
    {
        public string TeamName { get; set; }
        public List<string> MemberList { get; set; }
        public string CreatorName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            createTeams(n, teams);
            getUsersToMemberList(teams);
            printResult(teams);
        }

        private static void createTeams(int n, List<Team> teams)
        {
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split('-');
                var creator = input[0];
                var nameOfTeam = input[1];

                Team team = new Team();
                team.TeamName = nameOfTeam;
                team.CreatorName = creator;
                team.MemberList = new List<string>();

                bool teamIsAlreadyCreated = false;
                bool userAlreadyHasTeam = false;

                foreach (var t in teams)
                {
                    if (t.TeamName == team.TeamName)
                    {
                        teamIsAlreadyCreated = true;
                    }
                    if (t.CreatorName == team.CreatorName)
                    {
                        userAlreadyHasTeam = true;
                    }
                }

                if (teamIsAlreadyCreated)
                {
                    Console.WriteLine($"Team {team.TeamName} was already created!");
                    continue;
                }
                else if (userAlreadyHasTeam)
                {
                    Console.WriteLine($"{team.CreatorName} cannot create another team!");
                    continue;
                }
                else
                {
                    teams.Add(team);
                    Console.WriteLine($"Team {team.TeamName} has been created by {team.CreatorName}!");
                }
            }
        }

        private static void getUsersToMemberList(List<Team> teams)
        {
            string command = Console.ReadLine();
            while (command != "end of assignment")
            {
                var commandArgs = command.Split(new string[] {"->"}, StringSplitOptions.RemoveEmptyEntries);
                var userName = commandArgs[0];
                var teamName = commandArgs[1];

                bool teamExists = false;
                bool userIsalreadyInATeam = false;
                bool userIsCreatorOfATeam = false;

                foreach (var t in teams)
                {
                    if (t.TeamName == teamName)
                    {
                        teamExists = true;
                    }
                    if (t.MemberList.Contains(userName))
                    {
                        userIsalreadyInATeam = true;
                    }
                    if (t.CreatorName == userName)
                    {
                        userIsCreatorOfATeam = true;
                    }
                }

                if (!teamExists)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (userIsalreadyInATeam || userIsCreatorOfATeam)
                {
                    Console.WriteLine($"Member {userName} cannot join team {teamName}!");
                }
                else
                {
                    foreach (var t in teams)
                    {
                        if (t.TeamName == teamName)
                        {
                            t.MemberList.Add(userName);
                        }
                    }
                }

                command = Console.ReadLine();
            }

        }

        private static void printResult(List<Team> teams)
        {
            foreach (var item in teams.Where(t => t.MemberList.Count >0).OrderByDescending(t => t.MemberList.Count).ThenBy(t => t.TeamName))
            {
                Console.WriteLine(item.TeamName);
                Console.WriteLine($"- {item.CreatorName}");
                foreach (var member in item.MemberList.OrderBy(a => a))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var item in teams.Where(t =>t.MemberList.Count <1).OrderBy(t => t.TeamName))
            {
                Console.WriteLine(item.TeamName);
            }
        }
    }
}
