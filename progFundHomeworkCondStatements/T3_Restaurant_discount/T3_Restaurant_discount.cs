using System;

namespace T3
{
    class T3_Restaurant_discount
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            var packageType = Console.ReadLine().ToLower();
            double totalPricePerPerson = 0;
            var hallType = "";

            if (groupSize <= 50)
            {
                hallType = "Small Hall";
                switch (packageType)
                {
                    case "normal":
                        totalPricePerPerson = (2500 + 500 - ((2500 + 500)*0.05)) / groupSize;
                        break;
                    case "gold":
                        totalPricePerPerson = (2500 + 750 - ((2500 + 750) * 0.10)) / groupSize;
                        break;
                    case "platinum":
                        totalPricePerPerson = (2500 + 1000 - ((2500 + 1000) * 0.15)) / groupSize;
                        break;
                }
                Console.WriteLine($"We can offer you the {hallType}");
                Console.WriteLine($"The price per person is {totalPricePerPerson:F2}$");
            }
            else if (groupSize <= 100)
            {
                hallType = "Terrace";
                switch (packageType)
                {
                    case "normal":
                        totalPricePerPerson = (5000 + 500 - ((5000 + 500) * 0.05)) / groupSize;
                        break;
                    case "gold":
                        totalPricePerPerson = (5000 + 750 - ((5000 + 750) * 0.10)) / groupSize;
                        break;
                    case "platinum":
                        totalPricePerPerson = (5000 + 1000 - ((5000 + 1000) * 0.15)) / groupSize;
                        break;
                }
                Console.WriteLine($"We can offer you the {hallType}");
                Console.WriteLine($"The price per person is {totalPricePerPerson:F2}$");
            }
            else if (groupSize <= 120)
            {
                hallType = "Great Hall";
                switch (packageType)
                {
                    case "normal":
                        totalPricePerPerson = (7500 + 500 - ((7500 + 500) * 0.05)) / groupSize;
                        break;
                    case "gold":
                        totalPricePerPerson = (7500 + 750 - ((7500 + 750) * 0.10)) / groupSize;
                        break;
                    case "platinum":
                        totalPricePerPerson = (7500 + 1000 - ((7500 + 1000) * 0.15)) / groupSize;
                        break;
                }
                Console.WriteLine($"We can offer you the {hallType}");
                Console.WriteLine($"The price per person is {totalPricePerPerson:F2}$");
            }
            else
                Console.WriteLine("We do not have an appropriate hall.");
        }
    }
}
