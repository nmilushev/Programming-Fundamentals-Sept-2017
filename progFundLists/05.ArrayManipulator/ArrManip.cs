using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ArrayManipulator
{
    class ArrManip
    {
        static void Main(string[] args)
        {
            /*cool would be if using methods*/

            var listOfNumbers = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            var cmd = Console.ReadLine().Split();

            while (cmd[0] != "print")
            {
                switch (cmd[0])
                {
                    case "add":
                        listOfNumbers.Insert(int.Parse(cmd[1]), 
                                             int.Parse(cmd[2]));
                        break;
                    case "addMany":
                        List<int> addThose = new List<int>();
                        for (int i = 2; i < cmd.Length; i++)
                            addThose.Add(int.Parse(cmd[i]));
                            listOfNumbers.InsertRange(int.Parse(cmd[1]), addThose);
                        break;
                    case "contains":
                        if (listOfNumbers.Contains(int.Parse(cmd[1])))
                        {
                            Console.WriteLine(listOfNumbers.IndexOf(int.Parse(cmd[1])));
                        }
                        else
                        {
                            Console.WriteLine("-1");
                        }
                        break;
                    case "remove":
                        listOfNumbers.RemoveAt(int.Parse(cmd[1]));
                        break;
                    case "shift":
                        for (int i = 0; i < int.Parse(cmd[1]); i++)
                        {
                        ArrayShiftLeft(listOfNumbers);
                        }
                        break;
                    case "sumPairs":
                        List<int> sum = new List<int>(listOfNumbers.Count);

                        for (int i = 0; i < listOfNumbers.Count - 1; i += 2)
                        {
                            sum.Add(listOfNumbers[i] + listOfNumbers[i + 1]);
                        }
                        if (listOfNumbers.Count %2 != 0) //if odd amount of numbers, add the last number to the array
                        {
                            sum.Add(listOfNumbers[listOfNumbers.Count-1]);
                        }
                        listOfNumbers = new List<int>();
                        for (int i = 0; i < sum.Count; i ++)
                        {
                            listOfNumbers.Add(sum[i]);
                        }
                        break;
                }
                cmd = Console.ReadLine().Split();
            }

            Console.WriteLine($"[{String.Join(", ", listOfNumbers)}]");
        }

        private static void ArrayShiftLeft(List<int> array) //
        {
            int firstElement = 0;

            for (int i = 0; i < array.Count; i++)
            {
                if (i == 0)
                {
                    firstElement = array[i];
                }
                if (i == array.Count - 1)
                {
                    array[i] = firstElement;
                    break;
                }
                else
                {
                    array[i] = array[i + 1];
                }
            }
        }
    }
}
