using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PopulationCounter
{
    class PopCounter
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> countries =
                new Dictionary<string, Dictionary<string, long>>();

            string input = Console.ReadLine();

            while (input != "report")
            {
                string[] parameters = input.Split('|');

                string city = parameters[0];
                string country = parameters[1];
                long pop = long.Parse(parameters[2]);

                if (!countries.ContainsKey(country))
                {
                    countries.Add(country, new Dictionary<string, long>()); //need to initialize new dict
                    countries[country].Add(city, pop);
                }
                else
                {
                    if (!countries[country].ContainsKey(city))
                    {
                        countries[country].Add(city, pop);
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var country in countries.OrderByDescending(n => n.Value.Values.Sum())) //sorting the dict based on total country population
                    //(value of country is dict with city and pop) (values in last mentioned dict are all populations)
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");
                foreach (var city in country.Value.OrderByDescending(n => n.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
