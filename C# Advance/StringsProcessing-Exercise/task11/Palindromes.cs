
using System.Linq;

namespace task11
{
    using System;
    using System.Collections.Generic;

   public class Palindromes
    {
       public static void Main()
       {
           var input = Console.ReadLine().Split(",.?! ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries).ToArray();
            var matches = new List<string>();
           for (int i = 0; i < input.Length; i++)
           {
               var length = input[i].Length;
                var isMatch = true;
               var word = input[i];

                for (int j = 0; j < length/2; j++)
               {
                   if (word[j] != word[length - 1 - j])
                   {
                       isMatch = false;
                       break;
                    }
               }
               if (isMatch)
               {
                   matches.Add(input[i]);
               }
           }
           
           Console.WriteLine("[" + string.Join(", ", matches.OrderBy(x => x)) + "]");

        }
    }
}
