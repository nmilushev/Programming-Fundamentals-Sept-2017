using System;

namespace _09.LongerLine
{
    class Longer
    {
        static void CloserToCenter(double a, double b, double c, double d)
        {
            double dist1 = Math.Sqrt(a * a + b * b);
            double dist2 = Math.Sqrt(c * c + d * d);

            if (dist1 <= dist2)
                Console.Write($"({a}, {b})");
            else
                Console.Write($"({c}, {d})");
        }

        static void FarerToCenter(double a, double b, double c, double d)
        {
            double dist1 = Math.Sqrt(a * a + b * b);
            double dist2 = Math.Sqrt(c * c + d * d);

            if (dist1 > dist2)
                Console.Write($"({a}, {b})");
            else
                Console.Write($"({c}, {d})");
        }

        static void LongerLine(double a, double b, double c, double d,
            double e, double f, double g, double h)
        {
            double line1 = Math.Sqrt((a - c) * (a - c) + (b - d) * (b - d));
            double line2 = Math.Sqrt((e - g) * (e - g) + (f - h) * (f - h));

            if (line1 >= line2)
            {
                CloserToCenter(a, b, c, d);
                FarerToCenter(a, b, c, d);
            }
            else
            {
                CloserToCenter(e, f, g, h);
                FarerToCenter(e, f, g, h);
            }
        }

        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double t = double.Parse(Console.ReadLine());
            double s = double.Parse(Console.ReadLine());
            double q = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double r = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            LongerLine(x, y, t, s, q, w, r, z);
        }
    }
}
