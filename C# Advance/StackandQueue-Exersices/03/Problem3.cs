
namespace _03
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Problem3
    {
        public static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var stack = new Stack<long>();

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (input[0] == 2)
                {
                    stack.Pop();
                }
                else if (input[0] == 3)
                {
                    Console.WriteLine(stack.Peek());
                }
                else
                {
                    stack.Push(input[1]);
                }
            }

        }
    }
}
