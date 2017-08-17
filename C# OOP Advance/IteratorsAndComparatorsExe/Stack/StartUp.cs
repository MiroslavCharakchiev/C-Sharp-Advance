using System;
using System.Linq;

namespace Stack
{
    public class StartUp
    {
        public static void Main()
        {
            var stack = new Stack<string>();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var tokens = input.Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var command = tokens[0];
                var elements = tokens.Skip(1).ToArray();

                switch (command)
                {
                    case "Push":
                        foreach (var element in elements)
                        {
                            stack.Push(element);
                        }
                        break;
                    case "Pop":
                        try
                        {
                            stack.Pop();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        } 
                        break;
                }
            }
            printStack(stack);
        }

        private static void printStack(Stack<string> stack)
        {
            for (int i = 0; i < 2; i++)
            {
                foreach (var item in stack)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
