

namespace task09
{
    using System;
   public class Program
    {
       public static void Main()
        {
            var match = Console.ReadLine().Split(", ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);

            var input = Console.ReadLine();

            for (int i = 0; i < match.Length; i++)
            {
                for (int j = 0; j < input.Length - match[i].Length; j++)
                {
                    var sub = input.Substring(j, match[i].Length);

                    if (match[i] == sub)
                    {
                       input = input.Replace(sub, new string('*',sub.Length));
                        break;
                    }
                }
            }
            Console.WriteLine(input);
            
        }
    }
}
