using System;
using System.Runtime.Remoting;
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
            if (num2 == String.Empty || num1 == String.Empty)
            {
                Console.WriteLine('0');
            }
            else
            {
                Console.WriteLine((SumBigNums(num1, num2)));
            }
        }

        private static string SumBigNums(string num1, string num2)
        {
            StringBuilder sumLike = new StringBuilder();
            int reminder = 0;
            for (int i = Math.Max(num1.Length, num2.Length) - 1; i >= 0; i--)
            {
                int currentProd = 0;
                if (reminder != 0)
                {
                    currentProd = (num1[i] - 48) * (num2[0] - 48) + reminder;
                }
                else
                {
                    currentProd = (num1[i] - 48) * (num2[0] - 48);
                }

                if (currentProd > 10)
                {
                    if (i == 0)
                    {
                        sumLike.Insert(0, currentProd);
                    }
                    else
                    {
                        sumLike.Insert(0, currentProd % 10);
                        reminder = (int)currentProd / 10;
                    }
                }
                else
                {
                    if (i == 0)
                    {
                        sumLike.Insert(0, currentProd);
                    }
                    else
                    {
                        sumLike.Insert(0, currentProd % 10);
                        reminder = 0;
                    }
                }
            }
            return sumLike.ToString();
        }
    }
}
