using System;
using System.Linq;

namespace _11.EqualSums
{
    class EqSums
    {
        static void Main(string[] args)
        {
            var text1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int leftSum = 0, rightSum = 0;
            bool printNo = false;
            for (int i = 0; i < text1.Length; i++)
            {
                leftSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += text1[j];
                }
                rightSum = 0;
                for (int j = text1.Length-1; j > i; j--)
                {
                    rightSum += text1[j];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    printNo = false;
                    break;
                }
                else
                {
                    printNo = true;
                }
            }
            if (printNo)
            {
                Console.WriteLine("no");
            }
        }
    }
}
