using System;

namespace _10.CubePrp
{
    class Cube
    {
        static double CubeFunct(double side, string prop)
        {
            switch (prop)
            {
                case "face":
                    return Math.Sqrt(2 * (side * side));
                case "space":
                    return Math.Sqrt(3 * (side * side)); ;
                case "volume":
                    return side * side * side;
                case "area":
                    return 6 * (side * side);
                default:
                    return 0;
            }
        }

        static void Main(string[] args)
        {
            double edge = double.Parse(Console.ReadLine());
            string property = Console.ReadLine();
            Console.WriteLine($"{CubeFunct(edge, property):F2}");
        }
    }
}
