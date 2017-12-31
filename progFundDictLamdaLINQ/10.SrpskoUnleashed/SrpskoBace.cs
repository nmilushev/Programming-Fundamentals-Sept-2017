using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10.SrpskoUnleashed
{
    class SrpskoBace
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> srpsko =
                                    new Dictionary<string, Dictionary<string, long>>(); //venue, singer, money

            var inputLine = Console.ReadLine();
            while (inputLine != "End")
            {
                string[] inputArgs = inputLine.Split('@');
                string ignoreString = inputArgs[0];
                string[] newArgs = inputArgs[1].Split(' ');
                bool skipString = newArgs.Count() < 3;//&& newArgs.Count() > 4;
                bool terminate = false;
                while (ignoreString[ignoreString.Length - 1] != ' ' || (skipString))
                {
                    inputLine = Console.ReadLine();
                    if (inputLine == "End")
                    {
                        terminate = true;
                        break;
                    }
                    else
                    {
                        inputArgs = inputLine.Split('@');
                        ignoreString = inputArgs[0];
                        newArgs = inputArgs[1].Split(' ');
                        skipString = newArgs.Count() < 3;
                    }
                }
                if (!terminate)
                {
                    newArgs = inputArgs[1].Split(' ');
                    string singer = inputArgs[0];
                    long ticketCount = long.Parse(newArgs[newArgs.Length - 1]);
                    string checkVenue2 = newArgs[newArgs.Length - 2];
                    long checkVenue = checkVenue2[0];
                    while (checkVenue > 57 || checkVenue < 48)
                    {
                        inputLine = Console.ReadLine();
                        if (inputLine == "End")
                        {
                            terminate = true;
                            break;
                        }
                        else
                        {
                            inputArgs = inputLine.Split('@');
                            ignoreString = inputArgs[0];
                            while (ignoreString[ignoreString.Length - 1] != ' ' || (skipString))
                            {

                                inputLine = Console.ReadLine();
                                if (inputLine == "End")
                                {
                                    terminate = true;
                                    break;
                                }
                                else
                                {
                                    inputArgs = inputLine.Split('@');
                                    ignoreString = inputArgs[0];
                                    newArgs = inputArgs[1].Split(' ');
                                    skipString = newArgs.Count() < 3;// && newArgs.Count() > 4; ;
                                }
                            }
                            if (!terminate)
                            {
                                newArgs = inputArgs[1].Split(' ');
                                singer = inputArgs[0];
                                ticketCount = long.Parse(newArgs[newArgs.Length - 1]);
                                checkVenue2 = newArgs[newArgs.Length - 2];
                                checkVenue = checkVenue2[checkVenue2.Length - 1];
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    if (!terminate)
                    {
                        long ticketPrice = long.Parse(newArgs[newArgs.Length - 2]);
                        long totalEarnings = (long)ticketCount * ticketPrice;
                        StringBuilder venue = new StringBuilder();
                        for (long i = 0; i < newArgs.Length - 2; i++)
                        {
                            venue.Append(newArgs[i] + " ").ToString();
                        }
                        string venueReal = venue.ToString();
                        if (!srpsko.ContainsKey(venueReal))
                        {
                            srpsko.Add(venueReal, new Dictionary<string, long>());
                        }
                        if (!srpsko[venueReal].ContainsKey(singer))
                        {
                            srpsko[venueReal].Add(singer, totalEarnings);
                        }
                        else
                        {
                            srpsko[venueReal][singer] += totalEarnings;
                        }
                        inputLine = Console.ReadLine();
                    }
                }
                else
                {
                    break;
                }
            }
            if (srpsko.Count() != 0)
            {
                foreach (var venue in srpsko)
                {
                    Console.WriteLine($"{venue.Key}");
                    foreach (var singer in venue.Value.OrderByDescending(s => s.Value))
                    {
                        Console.WriteLine($"#  {singer.Key}-> {singer.Value}");
                    }
                }
            }
        }
    }
}

