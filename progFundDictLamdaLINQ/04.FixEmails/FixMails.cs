using System;
using System.Collections.Generic;

namespace _04.FixEmails
{
    class FixMails
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var email = Console.ReadLine();
            var bulgarianEmails = new Dictionary<string, string>(); //name, email

            while (name != "stop")
            {

                bulgarianEmails[name] = email;

                name = Console.ReadLine();
                if (name != "stop")
                {
                    email = Console.ReadLine();
                }
            }
            foreach (var entry in bulgarianEmails)
            {
                string domain = entry.Value.Substring(entry.Value.Length - 2);
                if (domain == "bg")
                {
                    Console.WriteLine($"{entry.Key} -> {entry.Value}");
                }
            }
        }
    }
}
