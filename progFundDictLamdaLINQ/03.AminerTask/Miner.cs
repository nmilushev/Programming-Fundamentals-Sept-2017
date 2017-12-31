using System;
using System.Collections.Generic;

namespace _03.AminerTask
{
    class Miner
    {
        static void Main(string[] args)
        {
            var cmd = Console.ReadLine();

            var minerWarehouse = new Dictionary<string, int>(); //ore, quantity

            while (cmd != "stop")
            {

                if (minerWarehouse.ContainsKey(cmd))
                {
                    minerWarehouse[cmd] += int.Parse(Console.ReadLine());
                }
                else
                {
                    minerWarehouse[cmd] = int.Parse(Console.ReadLine());
                }
                cmd = Console.ReadLine();
            }
            foreach (var entry in minerWarehouse)
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
                // Console.WriteLine(String.Join("\n", dict.Select(x => x.Key + " -> "
                                                                        //+ x.Value)));
            }
        }
    }
}
