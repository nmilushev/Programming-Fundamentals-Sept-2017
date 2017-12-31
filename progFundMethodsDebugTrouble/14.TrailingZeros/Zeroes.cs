using System;
using System.Numerics;

namespace _14.TrailingZeros
{
    class Zeroes
    {
        static int TraiLZero(int n)
        {
            BigInteger fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            int count = 0;
            while (fact%10 == 0)
            {
                count++;
                fact /= 10;
            }
            return count;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(TraiLZero(n));
        }
    }
}
