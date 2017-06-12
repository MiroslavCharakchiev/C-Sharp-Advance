
namespace task01
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchFullName
    {
       public static void Main()
        {
            var regex = new Regex("[A-Z][a-z]+ [A-Z][a-z]+$");

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
