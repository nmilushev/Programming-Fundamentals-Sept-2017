using System;

namespace T16_CompareFloats
{
    class CompFloats
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            bool equal = true;
            if (Math.Abs(a-b) > eps)
            {
                Console.WriteLine(a==b);
            }
            else if (Math.Abs(a - b) < eps)
            {
                Console.WriteLine(equal);
            }
            else
            {
                Console.WriteLine(!equal);
            }
        }
    }
}
