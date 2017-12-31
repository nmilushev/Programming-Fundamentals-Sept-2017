using System;

namespace _11.GeometryCalc
{
    class Geometry
    {

        static double GeometryArea(string fig)
        {
            double a, b;
            switch (fig)
            {
                case "triangle":
                    a = double.Parse(Console.ReadLine());
                    b = double.Parse(Console.ReadLine());
                    return (a*b)/2;
                case "rectangle":
                    a = double.Parse(Console.ReadLine());
                    b = double.Parse(Console.ReadLine());
                    return a * b;
                case "square":
                    a = double.Parse(Console.ReadLine());
                    return a*a;
                case "circle":
                    a = double.Parse(Console.ReadLine());
                    return Math.PI*(a*a);
                default:
                    return 0;
            }
        }
        static void Main(string[] args)
        {
            string figure = Console.ReadLine().ToLower();
            Console.WriteLine($"{GeometryArea(figure):F2}");
        }
    }
}
