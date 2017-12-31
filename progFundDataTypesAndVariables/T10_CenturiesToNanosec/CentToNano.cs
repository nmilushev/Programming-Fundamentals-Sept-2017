using System;

namespace T10_CenturiesToNanosec
{
    class CentToNano
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries*100;
            int days = (int)(years*365.2422);
            double hours = days*24;
            double minutes = hours*60;
            double seconds = minutes*60; //long?
            long milliseconds = (long)(seconds*1000);
            decimal microsec = milliseconds*1000;
            decimal nanosec = microsec*1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days " +
                              $"= {hours} hours = {minutes} minutes = " +
                              $"{seconds} seconds = {milliseconds} milliseconds = " +
                              $"{microsec} microseconds = {nanosec} nanoseconds");
        }
    }
}
