
namespace task13
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

   public class MagicalExchangebleWords
    {
       public static void Main()
        {
            var input = Console.ReadLine().Split();

            Console.WriteLine(isTrue(input[0], input[1]).ToString().ToLower());

        }

        private static bool isTrue(string a, string b)
        {

            var isIttrue = false;

            var dict = new Dictionary<char, char>();

            var first = a.ToArray();
            var second = b.ToArray();
            var length = Math.Min(first.Length, first.Length);

            if (first.Length == second.Length)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    if (!dict.ContainsKey(first[i]))
                    {
                        dict[first[i]] = second[i];
                    }
                    else
                    {
                        if (dict[first[i]] == second[i])
                        {
                            isIttrue = true;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    if (!dict.ContainsKey(first[i]))
                    {
                        dict[first[i]] = second[i];
                    }
                    else
                    {
                        if (dict[first[i]] == second[i])
                        {
                            isIttrue = true;
                        }
                    }
                }
            }

            return isIttrue;
        }
    }
}
