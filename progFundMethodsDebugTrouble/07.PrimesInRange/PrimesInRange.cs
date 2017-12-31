using System;
using System.Collections.Generic;

namespace _07.PrimesInRange
{
    class PrimesInRange
    {
        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> containPrimes = new List<int>();
            bool primeIam = true;
            if (startNum == 0 || startNum == 1)
            {
                for (int i = startNum + 2; i <= endNum; i++)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            primeIam = false;
                            break;
                        }
                        else
                        {
                            primeIam = true;
                        }
                    }
                    if (primeIam)
                    {
                        containPrimes.Add(i);
                    }
                    primeIam = false;
                }
            }
            else
            {
                for (int i = startNum; i <= endNum; i++)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            primeIam = false;
                            break;
                        }
                        else
                        {
                            primeIam = true;
                        }
                    }
                    if (primeIam)
                    {
                        containPrimes.Add(i);
                    }
                    primeIam = false;
                }
            }

            return containPrimes;
        }

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            List<int> hasPrimes = new List<int>();
            hasPrimes = FindPrimesInRange(a, b);
            string allNums = "";
            for (int i = 0; i < hasPrimes.Count; i++)
            {
                allNums += $"{hasPrimes[i]}" + ", ";
            }
            if (allNums.Length>2)
            {
                allNums = allNums.Remove(allNums.Length - 2);
            }
            Console.WriteLine(allNums);
        }
    }
}
