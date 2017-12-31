using System;

namespace _09.MerlahShake
{
    class Program
    {
        /*
         using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
 
namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = Console.ReadLine();
            string key = Console.ReadLine();
 
            while (true)
            {
 
               
                //find match
                int lastindex = test.LastIndexOf(key);
                int firstindex = test.IndexOf(key);
 
                //shake it or not
                if (firstindex != -1 && lastindex != -1 && firstindex!=lastindex
                   && key.Length > 0)
                {
                    Console.WriteLine("Shaked it.");
                    test = test.Remove(firstindex, key.Length);
                    lastindex = test.LastIndexOf(key);
                    test = test.Remove(lastindex, key.Length);
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(test);
                    break;
                }
                //change key
                int indexToremove = key.Length / 2;
                key = key.Remove(indexToremove, 1);
 
            }
        }
    }
}
             */
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            string editedStr = str1;
            //  Console.WriteLine(str1.IndexOf(str2));
            //  Console.WriteLine(str1.LastIndexOf(str2));
            while (true)
            {
                if (str1.Contains(str2))
                {
                    int indexFirstMatch = str1.IndexOf(str2);

                    editedStr = str1.Remove(indexFirstMatch, str2.Length);
                    int indexLastMatch = editedStr.LastIndexOf(str2);
                    if (indexLastMatch == -1)
                    {
                        Console.WriteLine("No shake.");
                        Console.WriteLine(str1);
                        break;
                    }
                    editedStr = editedStr.Remove(indexLastMatch, str2.Length);
                    Console.WriteLine("Shaked it.");
                    str1 = editedStr;
                }
                else
                {
                    Console.WriteLine("No shake.");
                    if (editedStr!=String.Empty)
                    {
                    Console.WriteLine(editedStr);
                    }
                    break;
                }
                if (str2.Length != 1)
                {
                    str2 = str2.Remove(str2.Length / 2, 1);
                }
                else
                {
                    Console.WriteLine("No shake.");
                    if (editedStr != String.Empty)
                    {
                        Console.WriteLine(editedStr);
                    }
                    break;
                }
                if (editedStr.Contains(str2))
                {
                    int indexFirstMatch = editedStr.IndexOf(str2);
                    editedStr = editedStr.Remove(indexFirstMatch, str2.Length);
                    int indexLastMatch = editedStr.LastIndexOf(str2);
                    if (indexLastMatch == -1)
                    {
                        Console.WriteLine("No shake.");
                        Console.WriteLine(editedStr);
                        break;
                    }
                    editedStr = editedStr.Remove(indexLastMatch, str2.Length);
                    Console.WriteLine("Shaked it.");
                    str1 = editedStr;
                }
                else
                {
                    Console.WriteLine("No shake.");
                    if (editedStr != String.Empty)
                    {
                        Console.WriteLine(editedStr);
                    }
                    break;
                }
            }
        }
    }
}