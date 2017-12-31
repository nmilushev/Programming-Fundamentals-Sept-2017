using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            //[A-Z]{2}\d+\.\d{1,2}[a-zA-Z]+[|]

            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, string>> database = 
                new Dictionary<string, Dictionary<string, string>>();
            Regex regex = new Regex(@"([A-Z]{2}\d+\.\d{1,2}[a-zA-Z]+[|])");

            while (input != "end")
            {
                var match = regex.Match(input).ToString();
                if (match.Length != 0)
                {
                    string city = "";
                    for (int i = 0; i < 2; i++)
                    {
                        city += match[i];
                    }

                    string temp = "";
                    for (int i = 2; i < match.Length - 6; i++)
                    {
                        temp += match[i];
                    }

                    string weatherType = "";
                    for (int i = match.Length - 6; i < match.Length - 1; i++)
                    {
                        weatherType += match[i];
                    }

                    if (!database.ContainsKey(city))
                    {
                        database.Add(city, new Dictionary<string, string>());
                        database[city].Add(weatherType, temp);
                    }
                    else
                    {
                        database[city] = new Dictionary<string, string>();
                        database[city][weatherType] = temp;
                    }
                     // Console.WriteLine(city);
                     // Console.WriteLine(temp);
                     // Console.WriteLine(weatherType);
                }
                input = Console.ReadLine();
            }

            foreach (var city in database.OrderBy(a => a.Value.Values.Min()))
            {
                Console.Write(city.Key + " => ");
                foreach (var item in city.Value)
                {
                    Console.Write($"{double.Parse(item.Value):F2} => {item.Key}");
                    Console.WriteLine();
                }

            }

        }
    }
}
