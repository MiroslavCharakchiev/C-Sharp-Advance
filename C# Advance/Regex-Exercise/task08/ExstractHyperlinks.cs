
using System.Text;
using System.Text.RegularExpressions;

namespace task08
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

   public class Program
    {
       public static void Main()
        {
            var sb = new StringBuilder();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                sb.Append(input).Append(" ");
            }

            var matches = Regex.Matches(sb.ToString(), @"<a\s+[^>]*?href\s*=(.*?)>.*?<\s*/\s*a\s*>");

            foreach (Match match in matches)
            {
                var posibleHref = match.Groups[1].ToString().Trim();
                if (posibleHref[0] == '"')
                {
                    Console.WriteLine(posibleHref.Split("\"".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).First());
                }
                else if (posibleHref[0] == '\'')
                {
                    Console.WriteLine(posibleHref.Split("'".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).First());
                }
                else
                {
                    Console.WriteLine(Regex.Split(posibleHref, @"\s+").First());
                }
             
            }

        }
    }
}
