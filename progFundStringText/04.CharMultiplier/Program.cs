using System;

namespace _04.CharMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArgs = Console.ReadLine().Split(' ');
            string str1 = inputArgs[0];
            string str2 = inputArgs[1];

            Console.WriteLine(MultiplyStrings(str1, str2));
        }

        public static int MultiplyStrings(string str1, string str2)
        {
            int sum = 0;
            for (int i = 0; i < Math.Min(str1.Length, str2.Length); i++)
            {
                sum += str1[i] * str2[i];
            }
            if (str1.Length > str2.Length)
            {
                for (int i = str2.Length; i <str1.Length; i++)
                {
                    sum += str1[i];
                }
            }
            else if (str1.Length < str2.Length)
            {
                for (int i = str1.Length; i < str2.Length; i++)
                {
                    sum += str2[i];
                }
            }
            return sum;
        }
    }
}
