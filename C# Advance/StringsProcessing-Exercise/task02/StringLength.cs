﻿
namespace task02
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
   public class StringLength
    {
       public static void Main()
       {
           var input = Console.ReadLine();
           var result = string.Empty;
            if (input.Length > 20)
            {
              result = input.Substring(0, 20);
                Console.WriteLine(result);

            }
            else
            {
                Console.WriteLine(input.PadRight(20, '*'));
            }


           
       }
    }
}
