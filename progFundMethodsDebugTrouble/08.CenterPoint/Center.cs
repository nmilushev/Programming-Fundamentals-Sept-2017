using System;

namespace _08.CenterPodouble
{
    class Center
    {

        static void DistanceToCenter (double a, double b, double c, double d)
        {
            double dist1 = Math.Sqrt(a*a + b*b);
            double dist2 = Math.Sqrt(c*c + d*d);

            if (dist1 <= dist2)
                Console.WriteLine($"({a}, {b})");
            else
                Console.WriteLine($"({c}, {d})");
        }

        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double t = double.Parse(Console.ReadLine());
            double s = double.Parse(Console.ReadLine());
            DistanceToCenter(x, y, t, s);
        }
    }
}
