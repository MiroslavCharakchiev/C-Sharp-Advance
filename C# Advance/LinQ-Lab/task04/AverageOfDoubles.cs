
namespace task04
{
    using System;
    using System.Linq;

   public static class AverageOfDoubles
    {
       public static void Main()
        {
            Console.WriteLine($@"{Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .Average():f2}");
        }
    }
}
