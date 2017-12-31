using System;
using System.Data;
using System.Linq;

namespace _02.ChangeList
{
    class ChList
    {
        static void Main(string[] args)
        {
            var listOfNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var cmd = Console.ReadLine().Split();
            while ((cmd[0] != "Odd") && (cmd[0] != "Even"))
            {
                switch (cmd[0])
                {
                    case "Delete":
                        while (listOfNumbers.Remove(int.Parse(cmd[1])))
                            listOfNumbers.Remove(int.Parse(cmd[1])); //remove all
                        break;
                    case "Insert":
                        listOfNumbers.Insert(int.Parse(cmd[2]),
                                             int.Parse(cmd[1]));
                        break;

                }
                cmd = Console.ReadLine().Split();
            }

            if (cmd[0] == "Even")
            {
                Console.Write(String.Join(" ", listOfNumbers.Where(x => x%2 == 0))); 
               // foreach (var num in listOfNumbers)
               // {
               //     if (num % 2 == 0)
               //     {
               //         // Console.Write(string.Join(" ", num));//now working why?
               //         Console.Write(num + " "); //need to trim
               //     }
               // }
                Console.WriteLine();
            }
            else
            {
                //alternative: cwrite(String.Join(" ", numbers.Where(x => x%2 != 0)))
                foreach (var num in listOfNumbers)
                {
                    if (num % 2 != 0)
                    {
                        // Console.Write(string.Join(" ", num)); //now working
                        Console.Write(num + " "); //need to trim
                    }
                }
                Console.WriteLine();

            }

        }
    }
}
