
namespace task04
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
   public class Program
    {
       public static void Main()
       {
           var input = Console.ReadLine().Split();
           var number = BigInteger.Parse(input[0]);
           var secNumber = BigInteger.Parse(input[1]);
            var stack = new Stack<BigInteger>();

           while (secNumber != 0)
           {
               var reminder = secNumber % number;
               secNumber = secNumber / number;
                stack.Push(reminder);
           }
           var count = stack.Count;
           for (int i = 0; i < count; i++)
           {
               Console.Write(stack.Pop());
            }

           Console.WriteLine();
        }
    }
}
