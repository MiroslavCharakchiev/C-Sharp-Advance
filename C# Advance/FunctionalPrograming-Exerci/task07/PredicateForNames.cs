
namespace task07
{
    using System;
    using System.Linq;

    public static class PredicateForNames
    {
        static void Main(string[] args)
        {
            var len = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split().ToArray();

            var result = names
                .Where(x => x.Length <= len)
                .ToArray();
            Console.WriteLine(string.Join("\r\n", result));
        }
    }
}
