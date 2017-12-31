using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"(?<city>[A-Z]{2})(?<temp>[0-9]{1,2}\.[0-9]{1,2})(?<weatherType>[A-Za-z]+)\|";
            var input = Console.ReadLine();

            Dictionary<string, SortedDictionary<float, string>> database = 
                new Dictionary<string, SortedDictionary<float, string>>();

            while (input != "end")
            {
                var match = Regex.Match(input, pattern);
                if (match.Length != 0)
                {
                    string city = match.Groups["city"].Value;
                    float temp = float.Parse(match.Groups["temp"].Value);
                    string weather = match.Groups["weatherType"].Value;
                    if (!database.ContainsKey(city))
                    {
                        SortedDictionary<float, string> weaTemp = new SortedDictionary<float, string>();
                        weaTemp.Add(temp, weather);
                        database.Add(city, weaTemp);
                    }
                    else
                    {
                        database.Remove(city);
                        database.Add(city, new SortedDictionary<float, string>());
                        database[city][temp] = weather;
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var city in database.OrderBy(x => x.Value.Keys.Min()))
            {
                foreach (var temperature in city.Value)
                {
                    string cityNew = city.Key;
                    float tempe = temperature.Key;
                    string weather = temperature.Value;
                    Console.WriteLine($"{cityNew} => {tempe:f2} => {weather}");
                }
            }
        }
    }
}