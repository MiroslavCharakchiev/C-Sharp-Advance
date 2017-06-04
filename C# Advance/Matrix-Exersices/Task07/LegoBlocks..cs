
namespace Task07
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var input = int.Parse(Console.ReadLine());

            var firstMatrix = new int[input][];
            var secondMatrix = new int[input][];
            var result = new int[input][];


            for (int i = 0; i < input; i++)
            {
                firstMatrix[i] = Console.ReadLine()
                    .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }
            for (int i = 0; i < input; i++)
            {
                secondMatrix[i] = Console.ReadLine()
                    .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }
            var isEqual = false;
            for (int i = 0; i < input - 1; i++)
            {
                if (firstMatrix[i].Length + secondMatrix[i].Length
                    == firstMatrix[i + 1].Length + secondMatrix[i + 1].Length)
                {
                    isEqual = true;
                }
                else
                {
                    isEqual = false;
                    break;
                }
            }
            var length = 0;

            if (isEqual)
            {

                for (int i = 0; i < input; i++)
                {
                    result[i] = firstMatrix[i].Concat(secondMatrix[i].Reverse()).ToArray();

                    Console.WriteLine("["+string.Join(", ", result[i])+"]");
                }
            }
            else
            {
                for (int i = 0; i < input; i++)
                {
                    length += firstMatrix[i].Length;
                    length += secondMatrix[i].Length;
                }
                Console.WriteLine($"The total number of cells is: {length}");
            }
        }
    }
}
