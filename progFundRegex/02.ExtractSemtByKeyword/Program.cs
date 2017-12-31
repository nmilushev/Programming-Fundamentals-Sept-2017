using System;
using System.Text.RegularExpressions;

namespace _02.ExtractSemtByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordContained = Console.ReadLine();
            string text = Console.ReadLine();

            Regex regex = new Regex(@"\b[^?.!]*\b" + $"{wordContained}"+ @"\b[^?.!]*"); //\b[^?.!]*\b{word}\b[^?.!]*
            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine($"{match.Value.Trim()}");
            }
        }
    }
}
