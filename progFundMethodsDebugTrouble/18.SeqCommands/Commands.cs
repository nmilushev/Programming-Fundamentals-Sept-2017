using System;
using System.Linq;

public class SequenceOfCommands_broken
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        int[] array = Console.ReadLine() // read array of numbers
           .Split(ArgumentsDelimiter)
           .Select(element => int.Parse(element))
           .ToArray();

        string[] line = Console.ReadLine().Trim().Split(ArgumentsDelimiter); //read command and two numbers

        while (!line[0].Equals("stop"))
        {
            int[] args = new int[2];

            if (line[0].Equals("add") ||
                line[0].Equals("subtract") ||
                line[0].Equals("multiply"))
            {
                args[0] = int.Parse(line[1]);
                args[1] = int.Parse(line[2]);
            }

            PerformAction(ref array, line[0], ref args);
            PrintArray(ref array);
            Console.WriteLine();
            line = Console.ReadLine().Trim().Split(ArgumentsDelimiter); //read another command and two numbers until 'stop'
        }
    }

    static void PerformAction(ref int[] arr, string action, ref int[] args) //void funct returning nothing - since ref type is used no need to return a value
    {
        //   int[] array = arr.Clone() as int[]; //no need since ref type is used
        int pos = args[0];
        int value = args[1];

        switch (action)
        {
            case "multiply":
                arr[pos - 1] *= value;
                break;
            case "add":
                arr[pos - 1] += value;
                break;
            case "subtract":
                arr[pos - 1] = arr[pos - 1] - value;
                break;
            case "lshift":
                ArrayShiftLeft(arr);
                break;
            case "rshift":
                ArrayShiftRight(arr);
                break;
        }
    }

    private static void ArrayShiftRight(int[] array)
    {
        int lastElement = 0;
        for (int i = array.Length - 1; i >= 1; i--)
        {
            if (i == array.Length - 1)
            {
                lastElement = array[i];
            }
            array[i] = array[i - 1];

            if (i == 1)
            {
                array[i - 1] = lastElement;
            }
        }
    }

    private static void ArrayShiftLeft(int[] array) //
    {
        int firstElement = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (i == 0)
            {
                firstElement = array[i];
            }
            if (i == array.Length - 1)
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

    private static void PrintArray(ref int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}
