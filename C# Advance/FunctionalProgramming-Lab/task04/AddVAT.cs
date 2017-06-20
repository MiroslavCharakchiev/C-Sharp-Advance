
namespace task04
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

   public class AddVAT
    {
       public static void Main()
        {
            try
            {
                var input = Console.ReadLine().Split(",".ToCharArray(),StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .Select(n => n*1.2).ToList();

                foreach (var number in input)
                {
                    Console.WriteLine($"{number:f2}");
                }
            }
            catch (Exception e)
            {
               
            }

        }
    }
}
