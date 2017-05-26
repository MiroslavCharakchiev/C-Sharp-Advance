
namespace _02
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Problem2
    {
        public static void Main()
        {
            var firstInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var secondInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var stack = new Stack<int>();

            for (int i = 0; i < firstInput[0]; i++)
            {
                stack.Push(secondInput[i]);
            }
            for (int i = 0; i < firstInput[1]; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(firstInput[2]))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
