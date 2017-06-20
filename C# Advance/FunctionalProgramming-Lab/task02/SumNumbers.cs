
using System.Security.AccessControl;

namespace task02
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

   public class SumNumbers
    {
       public static void Main()
       {
           var input = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

           Console.WriteLine($"{input.Count}\n{input.Sum()}");


       }
    }
}
