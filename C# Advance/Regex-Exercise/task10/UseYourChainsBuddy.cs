
using System.Text.RegularExpressions;

namespace task10
{
    using System;

   public class UseYourChainsBuddy
    {
       public static void Main()
       {
           var input = Console.ReadLine();

            var regex = new Regex(@"<p>(.*?)</p>");
           var matches = regex.Matches(input);
            
           foreach (Match match in matches)
           {
               var whithespaces = "[^0-9a-z]";
               var group = match.Groups[1].Value;
               var replased = Regex.Replace(group, whithespaces, " ");
               var pattern = "\\s+";
               replased = Regex.Replace(replased, pattern, " ");
               foreach (var symbol in replased)
               {
                   if (symbol >= 'a' && symbol <= 'm')
                   {
                       Console.Write((char)(symbol + 13));
                   }
                   else if (symbol >= 'n' && symbol <= 'z')
                   {
                       Console.Write((char)(symbol - 13));
                    }
                   else
                   {
                       Console.Write(symbol);
                    }
               }

           }

       }
    }
}
