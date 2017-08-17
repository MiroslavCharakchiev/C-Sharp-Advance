using System;
using System.Collections.Generic;

namespace StrategyPattern
{
   public class StartUp
    {
        public static void Main()
        {
            var nameSortedList = new SortedSet<Person>();
            var ageSortedList = new HashSet<Person>();

            var lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine().Split();
                nameSortedList.Add(new Person(input[0], int.Parse(input[1])));
                ageSortedList.Add(new Person(input[0], int.Parse(input[1])));
            }
            Console.WriteLine(nameSortedList.Count);
            Console.WriteLine(ageSortedList.Count);
        }
    }
}