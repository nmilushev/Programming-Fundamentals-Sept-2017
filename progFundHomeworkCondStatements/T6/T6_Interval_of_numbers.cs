﻿using System;

namespace T6
{
    class T6_Interval_of_numbers
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int minNum = Math.Min(num1, num2);
            int maxNum = Math.Max(num1, num2);
            for (int i = minNum; i <= maxNum; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
