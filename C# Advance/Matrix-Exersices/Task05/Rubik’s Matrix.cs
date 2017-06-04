
namespace Task05
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var frame = Console.ReadLine()
                 .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var rubix = new int[frame[0]][];
            var fuller = 1;
            for (int i = 0; i < rubix.Length; i++)
            {
                rubix[i] = new int[frame[1]];

                for (int j = 0; j < rubix[i].Length; j++)
                {
                    rubix[i][j] = fuller;
                    fuller++;
                }
            }

            var number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                var comand = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var position = int.Parse(comand[0]);
                var moves = int.Parse(comand[2]);
                var direction = comand[1];

                if (direction == "up")
                {
                   
                        for (int j = 0; j < moves % rubix.Length; j++)
                        {
                            for (int g = 0; g < rubix.Length - 1; g++)
                            {
                                var teemp = rubix[g][position];
                                rubix[g][position] = rubix[g + 1][position];
                                rubix[g + 1][position] = teemp;
                            }
                        }

                }
                else if (direction == "down")
                {
                    for (int j = 0; j < moves % rubix.Length; j++)
                    {
                        for (int g = 0; g < rubix.Length - 1; g++)
                        {
                            var teemp = rubix[rubix.Length - g - 1][position];
                            rubix[rubix.Length - g - 1][position] = rubix[rubix.Length - g - 2][position];
                            rubix[rubix.Length - g - 2][position] = teemp;
                        }
                    }
                }
                else if (direction == "left")
                {
                    for (int j = 0; j < moves % rubix.Length; j++)
                    {
                        for (int g = 0; g < rubix[position].Length - 1; g++)
                        {
                            var teemp = rubix[position][g];
                            rubix[position][g] = rubix[position][g + 1];
                            rubix[position][g + 1] = teemp;
                        }
                    }
                }
                else if (direction == "right")
                {
                    for (int j = 0; j < moves % rubix.Length; j++)
                    {
                        for (int g = 0; g < rubix[position].Length - 1; g++)
                        {
                            var teemp = rubix[position][rubix[position].Length - g - 1];
                            rubix[position][rubix[position].Length - g - 1] = rubix[position][rubix[position].Length - g - 2];
                            rubix[position][rubix[position].Length - g - 2] = teemp;
                        }
                    }
                }

            }
            var temp = 0;

            for (int i = 0; i < rubix.Length; i++)
            {
                for (int j = 0; j < rubix[i].Length; j++)
                {
                    if (temp + 1 == rubix[i][j])
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        GetPosition(rubix, temp, rubix[i][j]);
                    }
                    temp++;
                }
            }
        }

        private static void GetPosition(int[][] rubix, int temp, int curent)
        {
            var row = 0;
            var col = 0;
            for (int i = 0; i < rubix.Length; i++)
            {
                for (int j = 0; j < rubix[i].Length; j++)
                {
                    if (curent == rubix[i][j])
                    {
                        row = i;
                        col = j;
                    }
                    if (temp + 1 == rubix[i][j])
                    {
                        var swap = rubix[i][j];
                        rubix[i][j] = rubix[row][col];
                        rubix[row][col] = swap;
                        Console.WriteLine($"Swap ({row}, {col}) with ({i}, {j})");
                        return;
                    }
                }
            }
        }
    }
}
