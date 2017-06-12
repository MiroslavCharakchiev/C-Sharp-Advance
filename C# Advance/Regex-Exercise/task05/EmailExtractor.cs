
using System.Text.RegularExpressions;

namespace task05
{
    using System;

   public class EmailExtractor
    {
       public static void Main()
        {
            var pattern2 = @"(( [A-Za-z0-9][\w.-]+)@[a-z][a-z.-]+\.([a-z]+))";
            var input = Console.ReadLine();

            var matches = Regex.Matches(input, pattern2);

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
