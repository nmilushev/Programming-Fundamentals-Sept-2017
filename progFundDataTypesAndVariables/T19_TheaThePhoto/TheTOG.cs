using System;

namespace T19_TheaThePhoto
{
    class TheTOG
    {
        static void Main(string[] args)
        {
            long photosTaken = long.Parse(Console.ReadLine());
            long filterOnePhoto = long.Parse(Console.ReadLine()); //in seconds
            long filterFactor = long.Parse(Console.ReadLine()); //in percentages
            long uploadOnePhoto = long.Parse(Console.ReadLine()); //in seconds

            long totalTime = photosTaken*filterOnePhoto + (long)(Math.Ceiling(photosTaken*(filterFactor/100.0))*uploadOnePhoto);

            TimeSpan result = TimeSpan.FromSeconds(totalTime);
            Console.WriteLine(result.ToString(@"d\:hh\:mm\:ss"));
        }
    }
}
