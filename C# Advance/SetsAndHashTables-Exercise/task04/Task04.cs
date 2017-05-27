
namespace task04
{
    using System;
    using System.Collections.Generic;

    public class Task04
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToCharArray();
            var dict = new SortedDictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!dict.ContainsKey(input[i]))
                {
                    dict[input[i]] = 1;
                }
                else
                {
                    dict[input[i]]++;
                }
            }

            foreach (var symbol in dict)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
