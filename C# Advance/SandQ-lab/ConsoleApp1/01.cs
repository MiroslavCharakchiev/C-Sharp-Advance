namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
   public class Program
    {
       public static void Main(string[] args)
       {
           var input = Console.ReadLine().ToCharArray();

           var stack = new Stack<char>();

           foreach (var t in input)
           {
               stack.Push(t);
           }
           for (var i = 0; i < input.Length; i++)
           {
               Console.Write(stack.Pop());
           }
           Console.WriteLine();

       }
    }
}
