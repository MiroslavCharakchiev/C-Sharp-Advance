namespace task02
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Task02
    {
       public static void Main(string[] args)
       {
           var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
           var n = input[0];
           var m = input[1];

            var firstSet = new SortedSet<int>();
            var secondSet = new SortedSet<int>();

           for (int i = 0; i < n; i++)
           {
               var number = int.Parse(Console.ReadLine());
               firstSet.Add(number);
           }
           for (int i = 0; i < m; i++)
           {
               var number = int.Parse(Console.ReadLine());
               secondSet.Add(number);
           }

           foreach (var number in firstSet)
           {
               if (secondSet.Contains(number))
               {
                   Console.Write(number + " ");
               }
           }
       }
    }
}
