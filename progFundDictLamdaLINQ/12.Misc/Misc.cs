using System;
using System.Collections.Generic;
using System.Threading;

namespace _12.Misc
{
    class Misc
    {
        static void Main(string[] args)
        {
            var sortedDict = new SortedDictionary<string, string>
            {
                ["Niko"] = "+5678",
                ["Ivka"] = "+1234"
            };
            //even though Niko was added first the sorting 
            //will swap the 1st and the 2nd record, based on key, as I<N

            foreach (var key in sortedDict.Keys) //looping only the key values
            {
                Console.WriteLine(key);
            }
            foreach (var value in sortedDict.Values) //looping only the value values
            {
                Console.WriteLine(value);
            }
            Console.WriteLine(String.Join(", ", sortedDict.Keys)); //check only sortedDict
            Console.WriteLine(String.Join(", ", sortedDict)); //formating done in background
            //foreach (var name in sortedDict)
            //{
            //    Console.WriteLine($"{name.Key} -> {name.Value}");
            //}
            bool containKey = sortedDict.ContainsKey("Niko");
            Console.WriteLine(containKey);
            bool containValue = sortedDict.ContainsValue("Niko");
            Console.WriteLine(containValue);
            string a = "";
            var whatTypeIsIt = sortedDict.TryGetValue("Ivka",out a); //check on that out arguments
            Console.WriteLine(whatTypeIsIt);

        }
    }
}
