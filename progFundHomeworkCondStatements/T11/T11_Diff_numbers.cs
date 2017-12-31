using System;

namespace T11
{
    class T11_Diff_numbers
    {
        static void Main(string[] args)
        {
            //   int a = int.Parse(Console.ReadLine());
            //   int b = int.Parse(Console.ReadLine());
            //   int n1, n2, n3, n4, n5;
            //   n2 = a+1;
            //   n3 = a + 2;
            //   n4 = a+3;
            ////   n5 = a + 4;
            //   for (n5 = a+4; n5 < b; n5++)
            //       Console.WriteLine($"{a}{n2}{n3}{n4}{n5}");
            //   for (n4 = a+3; n4 < n5; n4++)
            //       Console.WriteLine($"{a}{n2}{n3}{n4}{n5}");
            //   for (n3 = a+3;  n3 < n4-1; n3++)
            //       Console.WriteLine($"{a}{n2}{n3}{n4-1}{n5}");

            //     for (n2 = a + 2; n2 < n3 - 1; n2++)
            //      Console.WriteLine($"{a}{n2}{n3-1}{n4 - 1}{n5}");
            //   for (n1 = a+1; n1 < n2-1; n1++)
            //       Console.WriteLine($"{n1}{n2-1}{n3 - 1}{n4 - 1}{n5}");
            //     Console.Write($"{a+i} ");
            //         Console.WriteLine();


            /*
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
          //  int maxSum = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = a; i >= 1; i--)
            {
                for (int j = 1; j >= b ; j++)
                {
                    Console.WriteLine($"{i} {j}");
                }
            }

        }
        //   Console.WriteLine("");
        */


            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int n1 = a, 
                n2 = n1+1, 
                n3 = n2+1, 
                n4 = n3+1, 
                n5 = n4+1;

            if (b-a < 4)
            {
                Console.WriteLine("No");
            }
            else
            {
             //   while (a <= n1 && n1 < n2 && n2 < n3 && n3 < n4 && n4 < n5 && n5 <= b)
             //   {
                    for (n1 = a; n1 < n2; n1++) //check upper boundary
                    {
                        for (n2 = n1+1; n2 < n3; n2++) //check upper boundary
                        {
                            for (n3 = n2+1; n3 < n4; n3++) //check upper boundary
                            {
                                for (n4 = n3+1; n4 < n5; n4++) //check upper boundary
                                {
                                    for (n5 = n4+1; n5 <= b; n5++) //check upper boundary
                                    {
                                        Console.WriteLine($"{n1} {n2} {n3} {n4} {n5}");
                                    }
                                }
                            }
                        }
                  //  }

                }


            }






        }
    }
}
