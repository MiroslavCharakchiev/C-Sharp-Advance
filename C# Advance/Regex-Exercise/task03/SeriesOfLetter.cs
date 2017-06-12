using System;
using System.Text.RegularExpressions;

namespace task03
{
   public class SeriesOfLetter
    {
       public static void Main()
       {
           var input = Console.ReadLine();

           input = Regex.Replace(input, "([A-Za-z])\\1+", "$1");

           Console.WriteLine(input);
       }
    }
}
