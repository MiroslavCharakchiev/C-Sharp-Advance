
namespace _09
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


   public class Problem9
    {
       public static void Main(string[] args)
       {
           var input = long.Parse(Console.ReadLine());

            var stack = new Stack<long>();

            stack.Push(0);
            stack.Push(1);
            var result = 0L;

           for (int i = 0; i < input -1; i++)
           {
                var firstNumber = stack.Pop();
              var  secondNumber = stack.Pop();
               result = firstNumber + secondNumber;
               stack.Push(secondNumber);
                stack.Push(firstNumber);
                stack.Push(result);
           }
           Console.WriteLine(result);
       }
    }
}
