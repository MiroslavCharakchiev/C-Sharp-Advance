
namespace task06
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
   public class CountMatches
    {
       public static void Main()
       {
           var input = Console.ReadLine();

           var match = Console.ReadLine().ToLower();

           var count = 0;
           for (int i = 0; i < input.Length - match.Length; i++)
           {
               var sub = input.Substring(i, match.Length).ToLower();
               
               if (match == sub)
               {
                   count++;
               }
           }
           Console.WriteLine(count);
       }
    }
}
