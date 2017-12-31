using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.UserLogs
{
    class Logs
    {
        static void Main(string[] args)
        {
            var spammers = new Dictionary<string,Dictionary<string, int>>(); //user, ip, count
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;  
                }
                string[] commandArgs = line.Split();
                string name = commandArgs[2].Replace("user=", ""); //remove 'user=' part from the last arg
                string ip = commandArgs[0].Replace("IP=", "");
                if (!spammers.ContainsKey(name))
                {
                    spammers.Add(name, new Dictionary<string, int>());
                }
                if (!spammers[name].ContainsKey(ip))
                {
                    spammers[name].Add(ip, 0);
                }
                spammers[name][ip] += 1;
            }
            foreach (var user in spammers.OrderBy(x => x.Key))
            {
                Console.WriteLine(user.Key + ": ");
                StringBuilder printLine = new StringBuilder();
                foreach (var ipAndCount in user.Value)
                {
                    printLine.Append(ipAndCount.Key).Append(" => ").Append(ipAndCount.Value + ", ");
                }
                printLine.Remove(printLine.Length - 2, 2);
                printLine.Append(".");
                Console.WriteLine(printLine.ToString());
           }
        }
    }
}
