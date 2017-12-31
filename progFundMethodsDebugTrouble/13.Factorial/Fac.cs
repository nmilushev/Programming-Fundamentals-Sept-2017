using System;
using System.Numerics;

namespace _13.Factorial
{
    class Fac
    {
        static BigInteger Factoriel(int n)
        {
            BigInteger fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Factoriel(n));
        }
    }
}
