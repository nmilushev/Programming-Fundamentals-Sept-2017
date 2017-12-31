using System;
using System.Linq;

namespace _06.SeqEqElem
{
    class EqEl
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (numbers.Length == 1)
            {
                Console.WriteLine(numbers[0]);
            }
            else
            {
                int count = 1, bestCount = 1, bestIndex = 0;
                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] == numbers[i - 1])
                    {
                        count++;
                    }
                    else
                    {
                        count = 1;
                    }
                    if (count > bestCount)
                    {
                        bestCount = count;
                        bestIndex = i - count + 1;
                    }
                }
                for (int i = bestIndex; i < bestCount + bestIndex; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}
