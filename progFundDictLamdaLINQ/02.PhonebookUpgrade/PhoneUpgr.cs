using System;
using System.Collections.Generic;

namespace _01.Phonebook
{
    class Phone
    {
        static void Main(string[] args)
        {
            var phonebook = new SortedDictionary<string, string>(); //name, phonenum

            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "END")
                {
                    break;
                }
                var command = inputLine.Split();
                if (command[0] == "A")
                {
                    phonebook[command[1]] = command[2]; //add entry
                }
                else if (command[0] == "S")
                {
                    if (!phonebook.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"Contact {command[1]} does not exist.");
                    }
                    else
                    {
                        foreach (var item in phonebook)
                        {
                            if (item.Key == command[1])
                            {
                                Console.WriteLine($"{item.Key} -> {item.Value}");
                            }
                        }
                    }
                }
                else if (command[0] == "ListAll")
                {
                    foreach (var entry in phonebook)
                    {
                        Console.WriteLine($"{entry.Key} -> {entry.Value}");
                    }
                }
            }
        }
    }
}
