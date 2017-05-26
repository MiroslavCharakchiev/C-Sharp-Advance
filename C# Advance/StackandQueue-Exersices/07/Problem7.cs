
namespace _07
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
            var input = Console.ReadLine();

            var stack = new Stack<char>();
            var match = new char[] {'(', '[', '{'};
            if (input.Length % 2 == 0)
            {

                for (int i = 0; i < input.Length; i++)
                {

                    if (match.Contains(input[i]))
                    {
                        stack.Push(input[i]);
                    }
                    else
                    {
                        if (stack.Peek() - input[i] <= 2)
                        {
                            if (stack.Any())
                            {
                                stack.Pop();
                            }
                        }
                        else
                        {
                            Console.WriteLine("NO");
                            break;
                        }
                    }
                }
                if (!stack.Any())
                {
                    Console.WriteLine("YES");
                }
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
