
namespace task07
{
    using System;
    using System.Linq;

  public static class BoundedNumbers
    {
       public static void Main(string[] args)
        {
            var bounds = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderBy(x => x)
                .ToArray();

            Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(x => bounds[0] <= x && x <= bounds[1])
                .ToList()
                .ForEach(x => Console.Write(x + " "));
        }
    }
}
