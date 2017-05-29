
namespace _11
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class problem11
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            var plants = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var plantsDie = new int[number];
            var previousPlants = new Stack<int>();

            previousPlants.Push(0);

            for (int i = 1; i < number; i++)
            {
                var lastDay = 0;
                while (previousPlants.Count > 0 && plants[previousPlants.Peek()] >= plants[i])
                {
                    lastDay = Math.Max(lastDay, plantsDie[previousPlants.Pop()]);
                }
                if (previousPlants.Count > 0)
                {
                    plantsDie[i] = lastDay + 1;
                }
                previousPlants.Push(i);
            }
            Console.WriteLine(plantsDie.Max());
        }
    }
}
