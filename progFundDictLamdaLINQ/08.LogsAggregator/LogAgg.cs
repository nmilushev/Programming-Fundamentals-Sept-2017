using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.LogsAggregator
{
    class LogAgg
    {
        static void Main(string[] args)
        {
        Dictionary<string, Dictionary<string,int>> users =
                new Dictionary<string, Dictionary<string, int>>();//user, IP, time
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string inputLine = Console.ReadLine();
                string[] line = inputLine.Split(' ');
                string ip = line[0];
                string name = line[1];
                int time = int.Parse(line[2]);

                if (!users.ContainsKey(name))
                {
                    users.Add(name, 
                            new Dictionary<string, int>());
                }
                if (!users[name].ContainsKey(ip))//adding unique city
                {
                    users[name].Add(ip, time);
                }
                else
                {
                        users[name][ip] += time;
                }
            }
            foreach (var user in users.OrderBy(x => x.Key))
            {
                Console.Write(user.Key + ": " + user.Value.Values.Sum() + " "); //+ user);
                Console.Write("[");
                 StringBuilder sb = new StringBuilder();
                foreach (var ip in users[user.Key].OrderBy(x => x.Key))
                {
                     sb = sb.Append(ip.Key).Append(", ");
                }
                StringBuilder one = sb.Remove(sb.Length - 2, 2);
                Console.Write(one);
                Console.Write("]");
                Console.WriteLine();
            }
        }
    }
}
