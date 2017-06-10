
using System.Text.RegularExpressions;

namespace task01
{
    using System;
   public class MatchCount
    {
       public static void Main()
       {
           var input = Console.ReadLine();

            var regex = new Regex("(\"|')(.+?)\\1");
           
           var matches = regex.Matches(input);

           foreach (Match m in matches)
           {
               Console.WriteLine(m.Groups[2]);
           }
        }
    }
}
