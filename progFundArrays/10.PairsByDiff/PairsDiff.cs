using System;
using System.Linq;


namespace _08.MostFreqNum
{
    class MFN
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int initialCount =0;
            int diff = 0;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {  
                    if (numbers[i] - numbers[j] == n || numbers[i] - numbers[j] == n*(-1))
                    {
                        initialCount++;
                    }
                }
            }
            Console.WriteLine(initialCount);
        }
    }
}
