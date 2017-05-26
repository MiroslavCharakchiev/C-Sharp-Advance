namespace _03
{
    using System;
    using System.Collections.Generic;
    public class fromNumberToBaynarry
    {
        public static void Main()
        {
            var input = int.Parse(Console.ReadLine());
            var stack = new Stack<string>();

            if (input == 0)
            {
                Console.WriteLine("0");
            }
            while (true)
            {
                if (input == 0)
                {
                    break;
                }
                if (input % 2 == 0)
                {
                    stack.Push("0");
                    input /= 2;
                }
                else
                {
                    stack.Push("1");
                    input /= 2;
                }
            }
            foreach (var symbol in stack)
            {
                Console.Write(symbol);
            }
        }
    }
}
