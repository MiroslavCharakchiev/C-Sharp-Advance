
namespace task03
{
    using System;
    using System.Linq;

    public static class CustomMinFunction
    {
       public static void Main()
        {
            Console.WriteLine(Console.ReadLine()
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Min());
        }
    }
}
