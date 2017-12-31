using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split(' ');
            int skipN = int.Parse(num[0]);
            int takeN = int.Parse(num[1]);
            string input = Console.ReadLine();

            Regex regex = new Regex(@"([|][<][\w]+)");

            var matches = regex.Matches(input)
                .Cast<Match>()
                .Select(a => a.Groups[1].Value)
                .ToArray();

            for (int i = 0; i < matches.Length; i++)
            {
                matches[i] = matches[i].Remove(0, skipN + 2);
                if (matches[i] == matches[matches.Length - 1])
                {
                    Console.Write(matches[i].Length > takeN ? matches[i].Remove(takeN) : matches[i]);
                }
                else
                {
                    if (matches[i].Length > takeN)
                        Console.Write(matches[i].Remove(takeN) + ", ");
                    else
                        Console.Write(matches[i] + ", ");
                }
            }
            Console.WriteLine();
        }
    }
}