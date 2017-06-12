
using System.Text.RegularExpressions;

namespace task06
{
    using System;

   public class SentanceExstractor
    {
       public static void Main()
       {
           var keyWord = Console.ReadLine();

           var input = Console.ReadLine();

           var pattern = $"([\\w+\\s]*(\\b{keyWord}\\b).+?[!\\.\\?])";

            var regex = new Regex(pattern);
           var matches = regex.Matches(input);

           foreach (Match match in matches)
           {
               Console.WriteLine(match);
           }
       }
    }
}
