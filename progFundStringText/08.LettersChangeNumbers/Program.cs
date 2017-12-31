using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[]{ }, 
                StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            foreach (var word in input)
            {
                double tempSum = 0;

                var firstLetter = word.First();
                var secondLetter = word.Last();
                double number = double.Parse(word.Substring(1, word.Length - 2));

                if (char.IsLower(firstLetter))
                {
                    tempSum = number * (firstLetter - ('a' - 1));
                }
                else
                {
                    tempSum = number / (firstLetter - ('A' - 1));
                }
                if (char.IsLower(secondLetter))
                {
                    tempSum += secondLetter - ('a' - 1);
                }
                else
                {
                    tempSum -= secondLetter - ('A' - 1);
                }

                sum += tempSum;
            }
            Console.WriteLine($"{sum:.00}");
        }
    }
}
