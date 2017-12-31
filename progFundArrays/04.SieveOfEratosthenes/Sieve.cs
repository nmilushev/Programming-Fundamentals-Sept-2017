using System;

namespace _04.SieveOfEratosthenes
{
    class Sieve
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] a = new bool[n+2]; 
            for (int i = 2; i < a.Length; i++)
            {
                a[i] = true;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (a[i] == true)
                {
                    for (int j = i+i; j <= n; j +=i)
                    {
                        a[j] = false;
                    }
                }
            }
            for (int i = 0; i <= n; i++)
            {
                if (a[i] == true)
                {
                    Console.Write((i) + " ");
                }
               
            }
        }
    }
}
