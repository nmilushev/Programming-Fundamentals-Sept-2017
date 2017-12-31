using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;

namespace _02.RotateAndSum
{
    class RotateSum
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Trim().Split(' ').ToArray();
            var numbers = new List<double>();

            for (int j = 0; j < input.Length; j++)
            {
                if (!input[j].Equals(string.Empty))
                {
                    double num = Convert.ToDouble(input[j]);
                    numbers.Add(num);
                }
            }
            int n = int.Parse(Console.ReadLine());

            double[] rotated1 = numbers.ToArray();
            double[] rotated2 = rotated1.Clone() as double[];
            double[] sumRot = new double[numbers.Count];
            //  if (n == 0)
            //  {
            //      for (int p = 0; p < numbers.Count; p++)
            //          Console.Write(rotated1[p]+" ");
            //  }
            //  else
            //  {
            if (n== 1)
            {
                double lastEl = 0;
                for (int m = 0; m < n; m++)
                {
                    for (int i = 1; i < numbers.Count; i++)
                    {
                        lastEl = rotated1[numbers.Count - 1];
                        rotated1[i] = rotated2[i - 1];
                        rotated1[0] = lastEl;
                        sumRot[i] += rotated1[i];
                        
                    }
                    sumRot[0] += rotated1[0];
                }
              //  rotated2 = rotated1.Clone() as long[];

                for (int p = 0; p < numbers.Count; p++)
                {
                    Console.Write(sumRot[p] + " ");
                }
                Console.WriteLine();
            }
//  else if (n == 0)
//   {
//       for (int i = 0; i < numbers.Count; i++)
//       {
//       Console.Write(numbers[i] +" ");
//       }
//       Console.WriteLine();
//  }
            else

            {
                for (int m = 0; m < n; m++)
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if ((n%2==0 &&numbers.Count%2!=0) || (n % 2 != 0 && numbers.Count % 2 == 0))
                        {
                        rotated1[i] = rotated2[(i + (n))%numbers.Count];
                        }
                        else
                        {
                            rotated1[i] = rotated2[(i + (n + 1)) % numbers.Count];
                        }
                        sumRot[i] += rotated1[i]; //that guy works
                    }
                    rotated2 = rotated1.Clone() as double[];
                }
                for (int p = 0; p < numbers.Count; p++)
                {
                   Console.Write(sumRot[p] + " ");
                    //Console.WriteLine(String.Join(" ", sumRot));
                }
                Console.WriteLine();
            }
        }
    }
}

