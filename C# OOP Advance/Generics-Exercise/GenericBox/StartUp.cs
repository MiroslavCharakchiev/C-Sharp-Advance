using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericBox
{
    public class StartUp
    {
       public static void Main()
        {
            var list = new List<Box<double>>();

            var lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                list.Add(new Box<double>(double.Parse(Console.ReadLine())));
            }
            var element = double.Parse(Console.ReadLine());

            Console.WriteLine(GetHigherElementsCount(list, element));
        }

        public static int GetHigherElementsCount<T>(List<Box<T>> list, T element)
            where T : IComparable<T>
        {
            var result = list.Count(b => b.Value.CompareTo(element) > 0);

            return result;
        }
    }
}
