using System;

namespace T15
{
    class T15_Neighbour_wars
    {
        static void Main(string[] args)
        {
            int healthGosho = 100, healthPesho = 100;
            int round = 1;
            string winnerName = "";
            int dmgPesho = int.Parse(Console.ReadLine());
            int dmgGosho = int.Parse(Console.ReadLine());
            while (healthGosho > 0 || healthPesho > 0)
            {
                if (round % 2 != 0)
                {
                    {
                        if (healthGosho - dmgPesho <= 0)
                        {
                            healthGosho -= dmgPesho;
                        }
                        else
                        {
                            Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {healthGosho - dmgPesho} health.");
                            healthGosho -= dmgPesho;
                        }
                    }
                    if (healthGosho <= 0)
                    {
                        Console.WriteLine($"Pesho won in {round}th round.");
                        break;
                    }
                }
                if (round % 2 == 0)
                {
                    {
                        if (healthPesho - dmgGosho <= 0)
                        {
                            healthPesho -= dmgGosho;
                        }
                        else
                        {
                            Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {healthPesho - dmgGosho} health.");
                            healthPesho -= dmgGosho;
                        }
                    }
                    if (healthPesho <= 0)
                    {
                        Console.WriteLine($"Gosho won in {round}th round.");
                        break;
                    }
                }
                if (round % 3 == 0)
                {
                    healthGosho += 10;
                    healthPesho += 10;
                }
                round++;
            }
        }
    }
}
