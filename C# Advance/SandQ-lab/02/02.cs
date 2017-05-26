namespace _02
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Reverse();

            var stack = new Stack<string>();

            foreach (var symbol in input)
            {
                stack.Push(symbol);
            }
            var sum = 0;
            var sing = string.Empty;

            for (var i = 0; i < input.Count(); i++)
            {
                var temp = stack.Pop();
                if (temp == "+" || temp == "-")
                {
                    sing = temp == "+" ? "+" : "-";
                }
                else
                {
                    var secnum = int.Parse(temp);
                    if (i != 0)
                    {
                        if (sing == "+")
                        {
                            sum += secnum;
                        }
                        else
                        {
                            sum -= secnum;
                        }
                    }
                    else
                    {
                        sum = secnum;
                    }

                }

            }
            Console.WriteLine(sum);
        }
    }

}
