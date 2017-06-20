
namespace task01
{
    using System;

    public static class ActionPrint
    {
       public static void Main()
        {
            Console.WriteLine(string.Join("\r\n", Console.ReadLine().Split()));
        }
    }
}
