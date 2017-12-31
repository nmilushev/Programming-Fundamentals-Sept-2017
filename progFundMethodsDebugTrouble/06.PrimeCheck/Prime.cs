using System;

namespace _06.PrimeCheck
{
    class Prime
    {
        static bool IsPrime(long n)
        {
            bool isPrime = !(n == 0 || n == 1); //well played, VS
            for (int i = 2; i <= (long)Math.Sqrt(n); i++)
            {
                if (n%i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }

        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(n));
        }
    }
}
