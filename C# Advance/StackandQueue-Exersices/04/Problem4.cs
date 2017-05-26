
namespace _04
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Problem4
    {
        public static void Main()
        {
            var firstInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var secondInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var queue = new Queue<int>();

            for (int i = 0; i < firstInput[0]; i++)
            {
                queue.Enqueue(secondInput[i]);
            }
            for (int i = 0; i < firstInput[1]; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(firstInput[2]))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
