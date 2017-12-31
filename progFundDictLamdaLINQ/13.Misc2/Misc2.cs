using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Misc2
{
    class Misc2
    {
        static void Main(string[] args)
        {

            Dictionary<string, Dictionary<string, int>> countries = 
                                new Dictionary<string, Dictionary<string, int>>();

            string inputLine = Console.ReadLine();

            while (true)
            {
                string[] line = inputLine.Split();
                string country = line[0];
              
                if (country == "end")
                {
                    break;
                }
                else
                {
                    string city = line[1];
                    int population = Convert.ToInt32(line[2]);

                if (!countries.ContainsKey(country))//adding unique country
                {
                    countries.Add(country, new Dictionary<string, int>());
                }
                if (!countries[country].ContainsKey(city))//adding unique city
                {
                    countries[country].Add(city, population);
                }
                else
                {
                    countries[country][city] += population; //if city exists update only popuulation
                }
                 inputLine = Console.ReadLine();
                }
            }
            foreach (var count in countries)
            {
                Console.WriteLine(count.Key + ": ");
                foreach (var city in countries[count.Key])
                {
                    Console.WriteLine($"-> {city.Key}, {city.Value}");
                }
            }


        }
    }
}
