using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Misc
{
    class Misc
    {
        static void Main(string[] args)
        {
            var listOfNumbers = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            List<int> sum = new List<int>(listOfNumbers.Count);
            for (int i = 0; i < listOfNumbers.Count-1; i+=2)
            {
                sum.Add(listOfNumbers[i] + listOfNumbers[i + 1]);
            }
            Console.WriteLine($"[{String.Join(", ", sum)}]");

 
        }
    }
}
