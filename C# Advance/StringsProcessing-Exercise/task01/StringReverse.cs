
using System.Text;

namespace task01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
  
   public class StringReverse
    {
       public static void Main()
       {
           var input = Console.ReadLine();
           var result = new StringBuilder();
           for (int i = input.Length -1; i >= 0; i--)
           {
               result.Append(input[i]);
           }
           Console.WriteLine(string.Join("",result));


       }
    }
}
