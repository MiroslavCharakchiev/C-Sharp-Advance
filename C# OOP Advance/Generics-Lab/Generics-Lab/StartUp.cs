using System;

namespace Generics_Lab
{
    public class StartUp
    {
        public static void Main()
        {
            Scale<int> scale = new Scale<int>(5, 5);
            Console.WriteLine(scale.GetHavier());
        }
    }
}