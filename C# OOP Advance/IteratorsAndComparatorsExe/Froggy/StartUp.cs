using System;
using System.Linq;

namespace Froggy
{
    public class StartUp
    {
       public static void Main()
       {
           var input = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse).ToArray();

            var lake = new Lake(input);
           Console.Write(string.Join(", ", lake));
       }
    }
}
