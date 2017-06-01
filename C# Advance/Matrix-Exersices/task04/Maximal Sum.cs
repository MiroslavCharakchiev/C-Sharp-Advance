
namespace task04
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class Program
    {
        public static void Main()
        {
            var frame = Console.ReadLine()
                .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var matrix = new int[frame[0]][];
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray(); ;
            }

            var maxSum = int.MinValue;
            var cubeMatrix = new int[3][];
            for (int i = 0; i < 3; i++)
            {
                cubeMatrix[i] = new int[3];
            }
            for (int i = 0; i < matrix.Length -2; i++)
            {
                for (int j = 0; j < matrix[i].Length - 2; j++)
                {
                    var curentSum = matrix[i][j] + matrix[i][j + 1] + matrix[i][j + 2]
                                    + matrix[i + 1][j] + matrix[i + 1][j+1] + matrix[i + 1][j+2]
                                    + matrix[i+2][j] + matrix[i+2][j+1] + matrix[i+2][j+2];
                    if (maxSum < curentSum )
                    {
                        maxSum = curentSum;
                        cubeMatrix[0][0] = matrix[i][j];
                        cubeMatrix[0][1] = matrix[i][j+1];
                        cubeMatrix[0][2] = matrix[i][j+2];
                        cubeMatrix[1][0] = matrix[i+1][j];
                        cubeMatrix[1][1] = matrix[i+1][j+1];
                        cubeMatrix[1][2] = matrix[i+1][j+2];
                        cubeMatrix[2][0] = matrix[i+2][j];
                        cubeMatrix[2][1] = matrix[i+2][j+1];
                        cubeMatrix[2][2] = matrix[i+2][j+2];
                    }
                }
            }
            Console.WriteLine("Sum = " +maxSum);
            foreach (var row in cubeMatrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
