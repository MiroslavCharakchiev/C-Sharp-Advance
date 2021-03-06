﻿namespace _06
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PrimePotato
    {
       public static void Main()
        {
            var input = Console.ReadLine();
            var number = int.Parse(Console.ReadLine());
            var queue = new Queue<string>(input.Split());

            var cycle = 1;
            while (queue.Count > 1)
            {
                for (int i = 0; i < number - 1; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                if (isPrime(cycle))
                {
                    Console.WriteLine($"Prime {queue.Peek()}");
                }
                else
                {
                    Console.WriteLine($"Removed {queue.Dequeue()}");
                }
                cycle++;
                
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
        public static bool isPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
