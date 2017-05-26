namespace _05
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
       public static void Main(string[] args)
       {
           var input = Console.ReadLine();
           var number = int.Parse(Console.ReadLine());
            var queue  = new Queue<string>(input.Split());

           while (queue.Count > 1)
           {
               for (int i = 0; i < number -1; i++)
               {
                   queue.Enqueue(queue.Dequeue());
               }
               Console.WriteLine($"Removed {queue.Dequeue()}");
            }
           Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
