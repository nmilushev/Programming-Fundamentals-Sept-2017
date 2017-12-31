using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;

namespace _12.Misc
{
    class RotateSum
    {
        static void Main(string[] args)
        {

           
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var n = int.Parse(Console.ReadLine());
            int[] sumRot = new int[input.Length];

            for (int j = 0; j < n; j++)
            {
                RotateArray(input);
                for (int i = 0; i < sumRot.Length; i++)
                {
                    sumRot[i] = sumRot[i] + input[i];
                }
            }
            Console.WriteLine(string.Join(" ", sumRot)); //puts separator b/n elements
        }

        private static void RotateArray(int[] input)
        {
            var lastNum = input.Last();
            for (int k = input.Length-1; k > 0; k--)
            {
                input[k] = input[k - 1];
            }
            input[0] = lastNum;
        }
        private static void TernaryOp()
        {
            int a = 5;
            int b = 10;

            Console.WriteLine(a < b ? "a is smaller" : "b is smaller");
        }
    }

    

   

}



/*03. FoldSum*/
/*
 using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.FoldAndSum
{
   class FoldSum
   {
       static void Main(string[] args)
       {
           var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
           int k = numbers.Length / 4;

           List<int> rightSide = new List<int>();

           for (int i = numbers.Length - 1; i >= numbers.Length - k; i--)
           {
               rightSide.Add(numbers[i]);
           }
          // Console.WriteLine("Right side: ");
          // for (int j = 0; j < rightSide.Count; j++)
          // {
          //     Console.Write(rightSide[j] + " ");
          // }
          // Console.WriteLine();

           List<int> leftSide = new List<int>();
           for (int i = k - 1; i >= 0; i--)
           {
               leftSide.Add(numbers[i]);
           }
           //  Console.WriteLine("Left side: ");
           //  for (int j = 0; j < leftSide.Count; j++)
           //  {
           //      Console.Write(leftSide[j] + " ");
           //  }
           //  Console.WriteLine();

           /*no need to reverse left side! done through reversing loop limits
           //reverse left side
           ReverseThatString(ref leftSide);
           Console.WriteLine("Reversed Left: ");
           for (int m  = 0; m < leftSide.Count; m++)
           {
               Console.Write(leftSide[m] + " ");
           }
           Console.WriteLine();
          // 

// /* no need to reverse right side! done through reversing loop limits
//reverse right side
ReverseThatString(ref rightSide);
Console.WriteLine("Reversed Right: ");
for (int m = 0; m < rightSide.Count; m++)
{
    Console.Write(rightSide[m] + " ");
}
Console.WriteLine();


// Console.WriteLine("Left & right side: ");
//for (int j = 0; j < leftSide.Count; j++)
//{
//    Console.Write(leftSide[j] + " ");
//}
leftSide.AddRange(rightSide);
       //     Console.WriteLine();
            int[] sum = leftSide.ToArray();
          //  Console.WriteLine("Summy yummy");
          //  for (int j = 0; j < sum.Length; j++)
          //  {
          //      Console.Write(sum[j] + " ");
          //  }
          //  Console.WriteLine();
            for (int i = 0; i<sum.Length; i++)
            {
                sum[i] += numbers[i + k];
            }
            // Console.WriteLine("Sum: ");
            // leftSide.AddRange(rightSide);
            for (int j = 0; j<leftSide.Count; j++)
            {
                Console.Write(sum[j] + " ");
            }
            Console.WriteLine();
        }

      //  private static void ReverseThatString(ref List<int> input)
      //  {
      //      var lastNum = input.Last();
      //      for (int k = input.Count - 1; k > 0; k--)
      //      {
      //          input[k] = input[k - 1];
      //      }
      //      input[0] = lastNum;
      //  }

    }
}

     */