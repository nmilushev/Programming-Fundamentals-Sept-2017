using System;
using System.Linq;

namespace _06.SeqIncElem
{
    class EqEl
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = 1, bestCount = 0, bestIndex = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1]) //increasing elem, not necessarily incremented by 1
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
