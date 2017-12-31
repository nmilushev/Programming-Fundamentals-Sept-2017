using System;

namespace T2
{
    class T2_Choose_drink_2
    {
        static void Main(string[] args)
        {
            var proffesion = Console.ReadLine();
            double totalPrice = 0.0;
            int amount = int.Parse(Console.ReadLine());
            switch (proffesion)
            {
                case "Athlete":
                    totalPrice = amount*0.7;
                    break;
                case "Businessman":
                case "Businesswoman":
                    totalPrice = amount * 1.0;
                    break;
                case "SoftUni Student":
                    totalPrice = amount * 1.7;
                    break;
                default:
                    totalPrice = amount * 1.2;
                    break;
            }
            Console.WriteLine($"The {proffesion} has to pay {totalPrice:F2}.");
        }
    }
}
