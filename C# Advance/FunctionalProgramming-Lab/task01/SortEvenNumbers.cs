
namespace task01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

   public class SortEvenNumbers
    {
       public static void Main()
        {
            Console.WriteLine(string.Join(", ",
            Console.ReadLine()
            .Split(", ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .Where(x => x % 2 == 0)
            .OrderBy(x => x)));

        }
    }
}
