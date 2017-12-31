using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());

        char search = 'р'; //was 'Search' instead
        bool hasMatch = false;

        for (int i = 0; i < text.Length; i++) //goes through whole string
        {
            if (text[i] == 112)
            {
                hasMatch = true;
                while (i + jump > text.Length - 1)
                {
                    jump--;
                }
                int endIndex = jump+1;
                string matchedString = text.Substring(i, endIndex); //not end index but how many elements
                Console.WriteLine(matchedString);
                i += jump;
            }
        }
        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}
