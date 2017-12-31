using System;
using System.Linq;

namespace _08.MostFreqNum
{
    class MFN
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] counts = new int[numbers.Length];
            var maxCount = 0;
            var mostFreqNum = 0;
            if (numbers.Length == 1)
            {
                Console.WriteLine(numbers[0]);
            }
            else
            {
                for (int i = 0; i < counts.Length; i++)
                {
                    counts[i]++; //every num found exists at least once
                }
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    for (int j = i + 1; j < numbers.Length; j++)
                    {
                        if (numbers[i] == numbers[j])
                        {
                            counts[i]++;
                        }
                    }
                    if (numbers[i] == numbers[i + 1])
                    {
                        i++;
                    }
                }
                for (int i = 0; i < counts.Length - 1; i++)
                {
                    if (maxCount < counts[i])
                    {
                        maxCount = counts[i];
                        mostFreqNum = numbers[i];
                    }
                }
                Console.WriteLine(mostFreqNum);
            }
        }
    }
}
