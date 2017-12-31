using System;
using System.Linq;

namespace _09.Misc
{
    public class ExchWordsStrings
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string str1 = input[0];
            string str2 = input[1];

            var charArr1 = str1.ToCharArray();
            var charArr2 = str2.ToCharArray();

            charArr1 = charArr1.Distinct().ToArray();
            charArr2 = charArr2.Distinct().ToArray();

            bool check1 = FirstCheck(charArr1, charArr2);
            if (!check1)
                Console.Write(check1.ToString().ToLower());
            else
            {
                bool check2 = SecondCheck(charArr1, charArr2);
                if (!check2)
                    Console.Write(check2.ToString().ToLower());
                else
                {
                    bool check3 = ThirdCheck(charArr1, charArr2);
                    Console.Write(check3.ToString().ToLower());
                }
            }
        }

        public static bool FirstCheck(char[] s1, char[] s2)
        {
            if (s1.Length.Equals(s2.Length))
                return true;
            else
                return false;
        }

        public static bool SecondCheck(char[] s1, char[] s2)
        {
            var sec = true;
            for (int i = 0; i < s1.Length; i++)
            {
                var index = s1.ToString();//ab
                var index2 = s2.ToString();//ox
                bool firstLast = (index.LastIndexOf(index[i]) == index2.LastIndexOf(index2[i]) && (index.IndexOf(index[i]) == index2.IndexOf(index2[i])));
                sec = firstLast;
            }
            return sec;
        }

        public static bool ThirdCheck(char[] s1, char[] s2)
        {
            var s1str = "";
            var s2str = "";
            for (int i = 0; i < s1.Length; i++)
            {
                s1str = s1.ToString().Replace(s1[i], ' ');
                s2str = s2.ToString().Replace(s1[i], ' ');
            }
            if (s1str.Length != s2str.Length)
                return false;
            else
                return true;
        }
    }
}