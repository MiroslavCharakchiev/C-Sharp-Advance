using System.Collections.Generic;

namespace task09
{
    using System;
    using System.Linq;

    public class Crossfire
    {
        public static void Main()
        {
            var frame = Console.ReadLine()
                .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var matrix = new string[frame[0]][];
            var counter = 1;
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new string[frame[1]];
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = counter.ToString();
                    counter++;
                }
            }

            while (true)
            {

                var comand = Console.ReadLine()
                    .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (comand[0] == "Nuke")
                {
                    break;
                }

                var row = long.Parse(comand[0]);
                var col = long.Parse(comand[1]);
                var range = long.Parse(comand[2]);
                // down
                if (col >= 0 && col < matrix[0].Length)
                {
                    
                    if (row >= 0 && row < matrix.Length)
                    {

                        for (int i = 0; i <= range; i++)
                        {
                            if (row + i >= matrix.Length)
                            {
                                break;
                            }
                            matrix[row + i][col] = " ";
                        }
                    }
                    else
                    {
                        if (row + range >= 0 && row + range <= matrix.Length)
                        {
                            for (var i = row + range; i > 0; i--)
                            {
                                matrix[i - 1][col] = " ";
                            }
                        }
                        if (row + range > matrix.Length && row < 0)
                        {
                            for (int i = matrix.Length; i > 0; i--)
                            {
                                matrix[i - 1][col] = " ";
                            }
                        }
                    }
                }

                // up
                if (col >= 0 && col < matrix[0].Length)
                {
                    
                    
                    if (row >= 0 && row < matrix.Length)
                    {
                        for (int i = 0; i <= range; i++)
                        {
                            if (row - i < 0)
                            {
                                break;
                            }
                            matrix[row - i][col] = " ";
                        }
                    }
                    else
                    {
                        if (row - range >= 0 && row - range < matrix.Length)
                        {
                            for (var i = row - range; i < matrix.Length; i++)
                            {
                                matrix[i][col] = " ";
                            }
                        }
                        if (row - range < 0 && row > 0)
                        {
                            for (int i = 0; i < matrix.Length; i++)
                            {
                                matrix[i][col] = " ";
                            }
                        }
                    }
                }


                // right
                if (row >= 0 && row < matrix[0].Length)
                { 

                   
                    if (col >= 0 && col < matrix[0].Length)
                    {
                        for (int i = 0; i <= range; i++)
                        {
                            if (col + i > matrix[row].Length - 1)
                            {
                                break;
                            }
                            matrix[row][col + i] = " ";
                        }
                    }
                    else
                    {
                        if (col + range >= 0 && col + range <= matrix[0].Length)
                        {
                            for (var i = col + range - 1; i >= 0; i--)
                            {
                                matrix[row][i] = " ";
                            }
                        }
                        if (col + range > matrix[0].Length && col < 0)
                        {
                            for (int i = matrix[0].Length -1; i >= 0; i--)
                            {
                                matrix[row][i] = " ";
                            }
                        }
                    }
                }


                // left
                if (row >= 0 && row < matrix[0].Length)
                {
                    
                    if (col >= 0 && col < matrix[0].Length)
                    {
                        for (int i = 0; i <= range; i++)
                        {
                            if (col - i < 0)
                            {
                                break;
                            }
                            matrix[row][col - i] = " ";
                        }
                    }
                    else
                    {
                        if (col - range >= 0 && col - range < matrix[0].Length)
                        {
                            for (var i = col - range; i < matrix[0].Length; i++)
                            {
                                matrix[row][i] = " ";
                            }
                        }
                        if (col - range < 0 && col > 0)
                        {
                            for (int i = 0; i < matrix[0].Length; i++)
                            {
                                matrix[row][i] = " ";
                            }
                        }
                    }
                }
                var queue = new Queue<string[]>();
                
                for (int i = 0; i < matrix.Length; i++)
                {
                    var isRowNull = 0;
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        if (matrix[i][j] == " ")
                        {
                            isRowNull++;
                        }
                    }
                    if (isRowNull != matrix[i].Length)
                    {
                        queue.Enqueue(matrix[i]);
                    }
                }
                matrix = new string[queue.Count][];
                for (int i = 0; i < matrix.Length; i++)
                {
                    matrix[i] = queue.Dequeue();
                }


                FallingDown(matrix);
            }

            foreach (var line in matrix)
            {
                Console.WriteLine(string.Join(" ", line));
            }
        }
        private static void FallingDown(string[][] stairs)
        {

            for (int col = 0; col < stairs[0].Length-1; col++)
            {
                for (int row = 0; row < stairs.Length; row++)
                {
                    if (stairs[row][col] == " ")
                    {
                        stairs[row][col] = stairs[row][col + 1];
                        stairs[row][col + 1] = " ";
                    }
                }
            }

        }
    }
}
