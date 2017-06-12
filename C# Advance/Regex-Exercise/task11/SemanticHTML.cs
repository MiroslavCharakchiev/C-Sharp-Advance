
using System.Text.RegularExpressions;

namespace task11
{
    using System;

   public class SemanticHTML
    {
       public static void Main()
       {

           var pattern1 = @"<(div)([^>]+)(?:id|class)\s*=\s*""(.*?)""(.*?)>";
           var pattern2 = @"</div>\s*<!--\s*(.*?)\s*-->";
           while (true)
           {
                var input = Console.ReadLine();

               if (input == "END")
               {
                   break;
               }

               var firstMatch = Regex.Match(input, pattern1);

               var secondMatch = Regex.Match(input, pattern2);
                    
               if (firstMatch.Success)
               {
                   input =Regex.Replace(input, pattern1, @"$3 $2 $4").Trim();
                   input = "<" + Regex.Replace(input, @"\s+", " ") + ">";
               }
               else if (secondMatch.Success)
               {
                   input = "</" + secondMatch.Groups[1] + ">";
               }

               Console.WriteLine(input);
           }
        }
    }
}
