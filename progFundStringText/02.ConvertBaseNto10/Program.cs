using System;
using System.Numerics;

namespace _02.ConvertBaseNto10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            byte baze = byte.Parse(input[0]);
            BigInteger num = BigInteger.Parse(input[1]);

            string number = num.ToString();
            BigInteger sum = 0;
            byte j = 0;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                sum += ((number[i]) - 48) * (BigInteger.Pow(baze, j)); //Math.Pow will return double, which leads to overflow
                j++;
            }
            Console.WriteLine(sum);
        }
    }
}