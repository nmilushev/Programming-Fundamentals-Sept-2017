using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _06.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] allUsers = input
                .Split(new char[] { ' ', '/', '\\', '(', ')' },
                StringSplitOptions.RemoveEmptyEntries);

            List<string> validUsernames =
                new List<string>();

            string patternForValidUsername = @"^[a-zA-Z]+[\w]{2,24}";

            Regex regex = new Regex(patternForValidUsername);

            for (int i = 0; i < allUsers.Length; i++)
            {
                MatchCollection matches = regex.Matches(allUsers[i]);
                foreach (Match match in matches)
                {
                    if (match.Value.Length < 26)
                    {
                    validUsernames.Add(match.Value);
                    }
                }
            }

            int currMax = 0;
            int index0 = 0;
            int index1 = 1;

            for (int i = 0; i < validUsernames.Count - 1; i++)
            {
                    if (validUsernames[i].Length+validUsernames[i+1].Length > currMax)
                    {
                        index0 = i;
                        index1 = i+1;
                        currMax = validUsernames[i].Length + validUsernames[i+1].Length;
                    }
            }
            Console.WriteLine(validUsernames[index0]);
            Console.WriteLine(validUsernames[index1]);
        }
    }
}
