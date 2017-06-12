
using System.Text.RegularExpressions;

namespace task02
{
    using System;
   public class MatchPhoneNumber
    {
      public static void Main()
        {
            var pattern = @"\+359( |-)(\d)\1\d{3}\1\d{4}$";
            var regex = new Regex(pattern);
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }
                var match = regex.Match(input);
                if (match.Success)
                {
                    Console.WriteLine(input);
                }

            }

        }
    }
}
