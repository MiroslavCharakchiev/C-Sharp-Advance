
namespace _01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   public class Program
    {
       public static void Main()
       {
           var input = Console.ReadLine().Split();
            var stack = new Stack<string>();

           for (int i = 0; i < input.Length; i++)
           {
               stack.Push(input[i]);
           }
           foreach (var symbol in stack)
           {
               Console.Write(symbol + " ");
           }
       }
    }
}
