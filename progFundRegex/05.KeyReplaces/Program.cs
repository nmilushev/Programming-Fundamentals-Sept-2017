using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _05.KeyReplaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var startKey = @"^[a-zA-Z]+[<|\\]";
            var endKey = @"[<|\\][a-zA-Z]+$";

            var firstKey = Regex.Match(input, startKey);
            var secondKey = Regex.Match(input, endKey);

            var firstK = firstKey.Value.TrimEnd('<', '|', '\\');
            var secondK = secondKey.Value.TrimStart('<', '|', '\\');

            var pattern = $"{firstK}(.*?){secondK}";

            var text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                sb.Append(match.Groups[1].Value);
            }

            Console.WriteLine(sb.Length < 1 ? "Empty result" : sb.ToString());
        }
    }
}
