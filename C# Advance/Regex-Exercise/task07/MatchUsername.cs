
using System.Text.RegularExpressions;

namespace task07
{
    using System;
    using System.Collections.Generic;

   public class MatchUsername
    {
       public static void Main()
        {
            var pattern = @"([\\\/ ]?(\b[A-Za-z][\w]+\b)[\\\/ ]?)";

            var regex = new Regex(pattern);

            var input = Console.ReadLine();

            var quoue = new Queue<string>();
            var matches = regex.Matches(input);
            foreach (Match match in matches)
            {
               var hit = match.Groups[2].ToString();
                if (hit.Length > 2 && hit.Length < 26)
                {
                    quoue.Enqueue(hit);
                }
            }
            var total = 0;
            var firstWord = string.Empty;
            var secondWord = string.Empty;
            var length = quoue.Count;
            for (int i = 0; i < length-1; i++)
            {
                var temp = quoue.Dequeue();
                if (total < temp.Length + quoue.Peek().Length)
                {
                    total = temp.Length + quoue.Peek().Length;
                    firstWord = temp;
                    secondWord = quoue.Peek();
                }
            }
            Console.WriteLine(firstWord);
            Console.WriteLine(secondWord);

        }
    }
}
