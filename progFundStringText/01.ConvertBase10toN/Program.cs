using System;
using System.Numerics;
using System.Text;

namespace _01.ConvertBase10toN
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            byte baze = byte.Parse(input[0]);
            BigInteger num = BigInteger.Parse(input[1]);

            StringBuilder sb = new StringBuilder();
            while (num > 0)
            {
                BigInteger wholeDigit = num / baze;
                BigInteger digitToAdd = num % baze;
                sb.Insert(0,(digitToAdd).ToString());
                num = wholeDigit;
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
