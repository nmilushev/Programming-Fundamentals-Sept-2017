using System;
using System.Text.RegularExpressions;

namespace _01.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"\s(([a-z0-9]+[_\-\.]?[a-z0-9]+)+)\@((([a-z0-9]+[_\-\.]?[a-z0-9]+([\.][a-z]+)+))+)"; // \w not appropriate since contains _

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine($"{match.Value}");
            }
        }
    }
}
