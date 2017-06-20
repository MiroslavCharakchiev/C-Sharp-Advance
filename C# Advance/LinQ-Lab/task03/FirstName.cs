
namespace task03
{
    using System;
    using System.Linq;

  public static class FirstName
    {
      public static void Main()
        {
            var names = Console.ReadLine()
                .Split();
            var letters = Console.ReadLine()
                .Split()
                .OrderBy(x => x);

            foreach (var letter in letters)
            {
                var result = names
                    .Where(w => w.ToLower().StartsWith(letter.ToLower()))
                    .FirstOrDefault();

                if (result != null)
                {
                    Console.WriteLine(result);
                    return;
                }
            }

            Console.WriteLine("No match");
        }
    }
}
