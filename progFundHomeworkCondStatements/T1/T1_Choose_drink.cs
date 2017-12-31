using System;

namespace T1
{
    class T1_Choose_drink
    {
        static void Main(string[] args)
        {
            var proffesion = Console.ReadLine().ToLower();
            switch (proffesion)
            {
                case "athlete":
                    Console.WriteLine("Water");
                    break;
                case "businessman":
                case "businesswoman":
                    Console.WriteLine("Coffee");
                    break;
                case "softuni student":
                    Console.WriteLine("Beer");
                    break;
                default:
                    Console.WriteLine("Tea");
                    break;
            }
        }
    }
}
