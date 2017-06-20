
namespace task02
{
    using System;
    using System.Linq;

   public static class UpperStrings
    {
       public static void Main()
        {
            Console.ReadLine()
                .Split()
                .ToList()
                .ForEach(x => Console.Write(x.ToUpper() + " "));
        }
    }
}
