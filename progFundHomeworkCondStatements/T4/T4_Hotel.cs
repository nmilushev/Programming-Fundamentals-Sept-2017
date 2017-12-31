using System;

namespace T4
{
    class T4_Hotel
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            double totalPriceStudio = 0.0;
            double totalPriceDouble = 0.0;
            double totalPriceSuite = 0.0;
            switch (month)
            {
                case "May":
                    if (nightsCount > 7)
                    {
                        totalPriceStudio = 50 * nightsCount - 0.05 * (50 * nightsCount);
                    }
                    else totalPriceStudio = 50 * nightsCount;
                    Console.WriteLine($"Studio: {totalPriceStudio:F2} lv.");
                    Console.WriteLine($"Double: {65 * nightsCount:F2} lv.");
                    Console.WriteLine($"Suite: {75 * nightsCount:F2} lv.");
                    break;
                case "October":
                    if (nightsCount > 7)
                    {
                        totalPriceStudio = 50 * (nightsCount-1) - 0.05 * (50 * (nightsCount-1));
                    }
                    else totalPriceStudio = 50 * nightsCount;
                    Console.WriteLine($"Studio: {totalPriceStudio:F2} lv.");
                    Console.WriteLine($"Double: {65 * nightsCount:F2} lv.");
                    Console.WriteLine($"Suite: {75 * nightsCount:F2} lv.");
                    break;
                case "June":
                    if (nightsCount > 14)
                    {
                        totalPriceDouble = 72 * nightsCount - (0.10 * (72 * nightsCount));
                    }
                    else totalPriceDouble = 72 * nightsCount;
                    Console.WriteLine($"Studio: {60 * nightsCount:F2} lv.");
                    Console.WriteLine($"Double: {totalPriceDouble:F2} lv.");
                    Console.WriteLine($"Suite: {82 * nightsCount:F2} lv.");
                    break;
                case "September":
                    if (nightsCount > 7)
                    {
                        totalPriceStudio = 60*(nightsCount-1);
                    }
                    if (nightsCount > 14)
                    {
                        totalPriceDouble = 72 * nightsCount - (0.10 * (72 * nightsCount));
                    }
                    else totalPriceDouble = 72 * nightsCount;
                    Console.WriteLine($"Studio: {totalPriceStudio:F2} lv.");
                    Console.WriteLine($"Double: {totalPriceDouble:F2} lv.");
                    Console.WriteLine($"Suite: {82 * nightsCount:F2} lv.");
                    break;
                case "July":
                case "August":
                case "December":
                    if (nightsCount > 14)
                    {
                        totalPriceSuite = 89 * nightsCount - 0.15 * (89 * nightsCount);
                    }
                    else totalPriceSuite = 89 * nightsCount;
                    Console.WriteLine($"Studio: {68 * nightsCount:F2} lv.");
                    Console.WriteLine($"Double: {77 * nightsCount:F2} lv.");
                    Console.WriteLine($"Suite: {totalPriceSuite:F2} lv.");
                    break;
            }

        }
    }
}
