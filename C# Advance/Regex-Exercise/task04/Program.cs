
using System.Text.RegularExpressions;

namespace task04
{
    using System;

   public class Program
    {
       public static void Main()
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                input = Regex.Replace(input, "(<a.+\"(.+)\">(.+)</a>)", "[URL href=\"$2\"]$3[/URL]");

                Console.WriteLine(input);
            }
            
        }
    }
}
