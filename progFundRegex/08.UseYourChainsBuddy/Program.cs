using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _08.UseYourChainsBuddy
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var paragraphsRegex = new Regex(@"<p>(?<message>.+?)<\/p>");

            var paragraphs = paragraphsRegex.Matches(input)
                .Cast<Match>()
                .Select(a => a.Groups["message"].Value)
                .Select(a => Regex.Replace(a, @"[^a-z0-9]", " "))
                .Select(a => Regex.Replace(a, @"\s{2,}", " "))
                .ToArray();

            //StringBuilder final = new StringBuilder();
            for (int i = 0; i < paragraphs.Length; i++)
            {
                paragraphs[i] = Rot13ToString(paragraphs[i]);
                //final.Append(paragraphs[i]);
            }
            //string[] finaleAle = final.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var match in paragraphs)
            {
                Console.Write(match);
            }
        }

        private static string Rot13ToString(string word)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char t in word)
            {
                sb.Append(Rot13(t));
            }
            return sb.ToString();
        }

        private static char Rot13(char letter)
        {
            if (!char.IsLetter(letter))
            {
                return letter;
            }
            var offset = char.IsLower(letter) ? 'a' : 'A';
            var rotatedLetter = (char)((letter - offset + 13) % 26 + offset);
            return rotatedLetter;
        }
    }
}