namespace task03
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Task03
    {
       public static void Main()
       {
           var number = int.Parse(Console.ReadLine());
           var set = new HashSet<string>();
           for (int i = 0; i < number; i++)
           {
               var input = Console.ReadLine().Split().ToArray();
               for (int j = 0; j < input.Length; j++)
               {
                   set.Add(input[j]);
               }
           }
           foreach (var element in set.OrderBy(x => x))
           {
               Console.Write(element + " ");
           }
       }
    }
}
