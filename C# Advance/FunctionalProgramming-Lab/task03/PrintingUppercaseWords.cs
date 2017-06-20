
namespace task03
{
    using System;
    using System.Linq;

   public static class PrintingUppercaseWords
    {
       public static void Main()
       {
           try
           {
               var input = Console.ReadLine().Split(" ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries)
                   .Where(w => w[0] >= 65 && 90 >= w[0])
                   .Select(w => w)
                   .ToList();

               Console.WriteLine(string.Join("\n", input));
            }
           catch (Exception e)
           {
             
           }
          
       }
    }
}
