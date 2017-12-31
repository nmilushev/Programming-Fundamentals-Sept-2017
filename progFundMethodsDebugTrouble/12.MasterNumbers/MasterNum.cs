using System;
using System.Linq;

namespace _12.MasterNumbers
{
    class MasterNum
    {
        //static bool IsSymm(int a) //memory limit
        //{
        //    bool sym = false;
        //    string output = new string(a.ToString().ToCharArray().Reverse().ToArray());
        //    if (a.ToString() == output)
        //    {
        //        sym = true;
        //    }
        //    return sym;
        //}
        static bool IsSymm(int a)
        {
            var number = a;
            var reverseNum = 0;
            while (a > 0)
            {
                int lastDigit = a % 10;
                reverseNum = reverseNum * 10 + lastDigit;
                a /= 10;
            }
            if (number == reverseNum)
                return true;
            else
                return false;
        }

        //static bool HasEven(int a) //alternative
        //{
        //    bool hasSeven = false;
        //    foreach (char t in a.ToString())
        //    {
        //        hasSeven = (t - 48) % 2 == 0;
        //        if (hasSeven)
        //        {
        //            return true;
        //        }
        //    }
        //    return hasSeven;
        //}
        static bool HasEven(int a)
        {
            bool even = false;
            while (a > 0)
            {
                if (a % 2 == 0)
                {
                    even = true;
                    break;
                }
                else
                {
                    even = false;
                }
                a /= 10;
            }
            return even;
        }

        //static bool BySeven (int a) //memory limit
        //{
        //    int sum = 0;
        //    for (int i = 0; i < a.ToString().Length; i++)
        //    {
        //        sum += (a.ToString()[i] - 48);
        //    }
        //    if (sum % 7 == 0)
        //        return true;
        //        return false;
        //}
        static bool BySeven(int a)
        {
            int sum = 0;
            while (a > 0)
            {
                sum += a % 10;
                a /= 10;
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                if (HasEven(i) && BySeven(i) && IsSymm(i))
                {
                    Console.WriteLine(i);
                }
            }
        }


    }
}
