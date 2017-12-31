using System;
using System.Text;

namespace _06.SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            num1 = num1.TrimStart('0');
            string num2 = Console.ReadLine();
            num2 = num2.TrimStart('0');

            Console.WriteLine(SumBigNums(num1, num2));
        }

        private static string SumBigNums(string num1, string num2)
        {
            StringBuilder sumLike = new StringBuilder();

            if (num1.Length > num2.Length)
            {
                num2 = num2.PadLeft(num1.Length, '0');
            }
            else
            {
                num1 = num1.PadLeft(num2.Length, '0');
            }
            int currentSum = 0;
            bool reminder = false;
            for (int i = num1.Length - 1; i >= 0; i--)
            {
                if (reminder)
                {
                    currentSum = ((int)num1[i] - 48) + ((int)num2[i] - 48) + 1;
                }
                else
                {
                    currentSum = ((int)num1[i] - 48) + ((int)num2[i] - 48);
                }
                if (currentSum >= 10)
                {
                    reminder = true;
                }
                else
                {
                    reminder = false;
                }
                if (reminder)
                {
                    if (i == 0)
                    {
                        if (num1[i] == 48 && num2[i] == 48)
                        {
                            break;
                        }
                        else
                        {
                            sumLike.Insert(0, currentSum);
                            break;
                        }
                    }
                    else
                    {
                        sumLike.Insert(0, currentSum % 10);
                    }
                }
                else
                {
                    if (i == 0)
                    {
                        if (num1[i] == 48 && num2[i] == 48)
                        {
                            if (currentSum>0)
                            {
                                sumLike.Insert(0, currentSum);
                                break;
                            }
                        }
                        else
                        {
                            sumLike.Insert(0, currentSum);
                            break;
                        }
                    }
                    else
                    {
                        sumLike.Insert(0, currentSum % 10);
                    }
                }
            }
            return sumLike.ToString();
        }
    }
}
