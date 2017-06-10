
using System;

namespace task15
{
   public class HarlemShake
    {
       public static void Main()
       {
           var input = Console.ReadLine();
           var pattern = Console.ReadLine();

           while (true)
           {
               var firstMatch = input.IndexOf(pattern);
               var secondMatch = input.LastIndexOf(pattern);

               if (firstMatch == -1 && firstMatch == secondMatch || pattern.Length == 0)
               {
                   Console.WriteLine("No shake.");
                   break;
               }
               input = input.Remove(secondMatch, pattern.Length);
               input = input.Remove(firstMatch, pattern.Length);
               pattern = pattern.Remove(pattern.Length / 2,1);
               Console.WriteLine("Shaked it.");
           }
           Console.WriteLine(input);
       }
    }
}
