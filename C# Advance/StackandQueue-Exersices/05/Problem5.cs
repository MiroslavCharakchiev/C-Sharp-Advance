
namespace _05
{
    using System;
    using System.Collections.Generic;
    public class Problem5
    {
        public static void Main()
        {
            var input = long.Parse(Console.ReadLine());
             var queue = new Queue<long>();
            queue.Enqueue(input);
            
            for (int i = 0; i < 50; i++)
            {
                var temp = queue.Dequeue();
                Console.Write(temp + " ");
                queue.Enqueue(temp + 1);
                queue.Enqueue((2 * temp + 1));
                queue.Enqueue(temp + 2);
            }
        }
    }
}
