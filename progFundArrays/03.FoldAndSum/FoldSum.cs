using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.FoldAndSum
{
    class FoldSum
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = numbers.Length / 4;

            List<int> rightSide = new List<int>();
            for (int i = numbers.Length - 1; i >= numbers.Length - k; i--)
            {
                rightSide.Add(numbers[i]);
            }

            List<int> leftSide = new List<int>();
            for (int i = k - 1; i >= 0; i--)
            {
                leftSide.Add(numbers[i]);
            }

            leftSide.AddRange(rightSide);

            int[] sum = leftSide.ToArray();
            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] += numbers[i + k];
            }
            for (int j = 0; j < leftSide.Count; j++)
            {
                Console.Write(sum[j] + " ");
            }
            Console.WriteLine();
        }
    }
}
