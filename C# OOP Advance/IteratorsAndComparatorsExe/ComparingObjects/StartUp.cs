using System;
using System.Collections.Generic;
using System.Linq;

namespace ComparingObjects
{
    public class StartUp
    {
        public static void Main()
        {
            var list  = new List<Person>();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var person = input.Split().ToArray();

                list.Add(new Person(person[0], int.Parse(person[1]), person[2]));
            }
            var index = int.Parse(Console.ReadLine()) - 1;

            var samePeopele = 0;
            var diferentPeopele = 0;
            foreach (var person in list)
            {
                if (list[index].CompareTo(person) == 0)
                {
                    samePeopele++;
                }
                else
                {
                    diferentPeopele++;
                }
            }
            if (samePeopele > 1)
            {
                Console.WriteLine($"{samePeopele} {diferentPeopele} {list.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}
