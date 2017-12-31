using System;

namespace T12_RectangleProperties
{
    class Rectangle
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double area = height*width;
            double perim = 2*(height + width);
            double diag = Math.Sqrt(height*height + width*width);
            Console.WriteLine(perim);
            Console.WriteLine(area);
            Console.WriteLine(diag);
        }
    }
}
