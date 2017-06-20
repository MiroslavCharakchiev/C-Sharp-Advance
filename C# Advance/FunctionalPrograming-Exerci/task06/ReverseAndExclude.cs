
namespace task06
{
    using System;
    using System.Linq;

   public static class ReverseAndExclude
    {
       public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse);
            var num = int.Parse(Console.ReadLine());
            var result = numbers
                .Reverse()
                .ToArray()
                .Where(x => x % num != 0)
                .ToArray();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
