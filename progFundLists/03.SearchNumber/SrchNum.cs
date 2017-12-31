using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SearchNumber
{
    class SrchNum
    {
        static void Main(string[] args)
        {
            var listOfNumbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

            var nums = Console.ReadLine()
                 .Split(' ')
                 .Select(int.Parse)
                 .ToArray();

            List<int> temp = new List<int>(nums[0]);
            for (int i = 0; i < nums[0]; i++)
            {
                temp.Add(listOfNumbers[i]);
            }
            int num1 = nums[1];
            for (int i = 0; i < num1; i++)
            {
                temp.RemoveAt(0); //alt: RemoveRange(0,num[1])
            }
            int num2 = nums[2];
            Console.WriteLine(temp.Contains(nums[2]) ? 
                                        "YES!" : "NO!");
        }
    }
}
