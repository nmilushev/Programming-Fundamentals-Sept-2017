using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _13.DynammicArray
{
    class DynArr
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];

            int currentCount = 0;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "print")
                {
                    Console.WriteLine(array.Length);
                }
                else
                {
                    array[currentCount] = int.Parse(command);
                    currentCount++;

                    if (currentCount == array.Length)
                    {
                        int[] tempArray = new int[array.Length];
                        for (int i = 0; i < array.Length; i++)
                        {
                            tempArray[i] = array[i];
                        }
                        array = new int[array.Length +1]; //alternatively *2, then for loops will not be executed that many times

                        for (int i = 0; i < tempArray.Length; i++)
                        {
                            array[i] = tempArray[i];
                        }
                    }
                 
                   
                }
            }
        }
    }
}
