using System;

namespace T5
{
    class Words_in_Plural
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            if (word.EndsWith("o") || word.EndsWith("ch") || word.EndsWith("s") || word.EndsWith("sh") || word.EndsWith("x") || word.EndsWith("z"))
            {
                word += "es";
            }
            else if (word.EndsWith("y"))
            {
                word = word.Remove(word.Length-1) + "ies";
            }
            else
            {
                word += "s";
            }
            Console.WriteLine(word);
        }
    }
}
