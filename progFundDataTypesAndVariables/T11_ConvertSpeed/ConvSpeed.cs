using System;

namespace T11_ConvertSpeed
{
    class ConvSpeed
    {
        static void Main(string[] args)
        {
            /*Note!!! using casts in the calculations is redundant. Adding .0 when dividing changes the precision to double*/
            float meters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());
            float totalHours = hours + minutes / 60 + seconds / 3600;
            float totalSeconds = hours * 3600 + minutes * 60 + seconds;
                Console.WriteLine($"{meters / totalSeconds}");
                Console.WriteLine($"{meters / 1000 / totalHours}");
                Console.WriteLine($"{meters / 1609 / totalHours}");
        }
    }
}