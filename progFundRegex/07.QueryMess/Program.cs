using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.QueryMess
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> database =
                new Dictionary<string, List<string>>();

            while (input != "END")
            {
                database =
                    new Dictionary<string, List<string>>();

                var paragraphsRegex = new Regex(@"(?<selectAll>.*)");

                var paragraphs = paragraphsRegex.Matches(input)
                    .Cast<Match>()
                    .Select(a => a.Groups["selectAll"].Value)
                    .Select(a => Regex.Replace(a, @"[\%]+[20]+", " "))
                    .Select(a => Regex.Replace(a, @"[\+]", " "))
                    .Select(a => Regex.Replace(a, @"\s{2,}", " "))
                    .Select(a => Regex.Replace(a, @"^.*?\?", ""))
                    .ToArray();

                string[] inputArgs = new string[20];
                for (int i = 0; i < paragraphs.Length - 1; i++)
                {
                    inputArgs = paragraphs[i].Split('&');
                }

                for (int i = 0; i < inputArgs.Length; i++)
                {
                    string[] inputArgsEquals = inputArgs[i].Split('=');
                    string key = inputArgsEquals[0].Trim();
                    string value = inputArgsEquals[1].Trim();

                    if (!database.ContainsKey(key))
                    {
                        database.Add(key, new List<string>());
                        database[key].Add(value);
                    }
                    else
                    {
                        database[key].Add(value);
                    }
                }
                foreach (var item in database)
                {
                    Console.Write($"{item.Key}=");
                    Console.Write("[");
                    foreach (var val in item.Value)
                    {
                        if (val == item.Value[item.Value.Count - 1])
                        {
                            Console.Write($"{val}");
                        }
                        else
                        {
                            Console.Write($"{val}, ");
                        }
                    }
                    Console.Write("]");
                }
                Console.WriteLine();

                input = Console.ReadLine();
            }
        }
    }
}
