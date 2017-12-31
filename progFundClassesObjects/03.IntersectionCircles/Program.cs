using System;
using System.Linq;

namespace _03.CirclesIntersection
{
   
    public class CirclesIntersection
    {
        public static void Main(string[] args)
        {
            var circle1Input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var circle1 = new Circle
            {
                X = circle1Input[0],
                Y = circle1Input[1],
                Radius = circle1Input[2]
            };

            var circle2Input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var circle2 = new Circle
            {
                X = circle2Input[0],
                Y = circle2Input[1],
                Radius = circle2Input[2]
            };

            bool isIntersect = Intersect(circle1, circle2);

            if (isIntersect)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        public static bool Intersect(Circle circle1, Circle circle2)
        {
            var firstPoint = Math.Abs(circle1.X - circle2.X);
            var secondPoint = Math.Abs(circle1.Y - circle2.Y);
            var distance = Math.Sqrt(Math.Pow(firstPoint, 2) + Math.Pow(secondPoint, 2));
            var sumRadiuses = circle1.Radius + circle2.Radius;

            if (distance <= sumRadiuses)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public class Circle
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int Radius { get; set; }
    }
}