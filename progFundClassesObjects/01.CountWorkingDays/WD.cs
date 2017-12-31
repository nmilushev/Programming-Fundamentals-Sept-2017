using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;

namespace _01.CountWorkingDays
{
    class WD
    {
        //some comment to check git
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
            int countWD = 0;

            for (DateTime d = startDate; d <= endDate; d = d.AddDays(1))
            {

                DateTime[] holidays = new DateTime[]
                {
                    new DateTime(d.Year, 1, 1),
                    new DateTime(d.Year, 3, 3),
                    new DateTime(d.Year, 5, 1),
                    new DateTime(d.Year, 5, 6),
                    new DateTime(d.Year, 5, 24),
                    new DateTime(d.Year, 9, 6),
                    new DateTime(d.Year, 9, 22),
                    new DateTime(d.Year, 11, 1),
                    new DateTime(d.Year, 12, 24),
                    new DateTime(d.Year, 12, 25),
                    new DateTime(d.Year, 12, 26)
                };

                if (!(d.DayOfWeek.ToString() == "Sunday" || d.DayOfWeek.ToString() == "Saturday"))
                {
                    if (!holidays.Contains(d.Date))
                    {
                        countWD++;
                    }   
                }
            }
            Console.WriteLine(countWD);
        }
    }
}
