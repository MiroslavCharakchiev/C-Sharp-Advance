
namespace _04
{
    using System;
    using System.Collections.Generic;
    public class Matching
    {
       public static void Main()
       {
           var input = Console.ReadLine();
            var stack = new Stack<int>();

           for (var i = 0; i < input.Length; i++)
           {
               if (input[i] == '(')
               {
                   stack.Push(i);
               }
               if (input[i] == ')')
               {
                   var start = stack.Pop();
                   Console.WriteLine(input.Substring(start, i - start + 1 ));
               }
           }
       }
    }
}
