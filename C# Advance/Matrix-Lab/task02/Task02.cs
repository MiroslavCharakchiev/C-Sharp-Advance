
namespace task02
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Task02
    {
       public static void Main()
        {
            var input = Console.ReadLine()
                .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var matrix = new int[input[0]][];
            var rowPosition = 0;
            var colPosition = 0;
            var sum = int.MinValue;

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }
            for (int i = 0; i < matrix.Length - 1; i++)
            {
                for (int j = 0; j < matrix[i].Length - 1; j++)
                {
                    var curentsum = matrix[i][j] + matrix[i][j + 1] + matrix[i + 1][j] + matrix[i + 1][j + 1];

                    if (sum < curentsum)
                    {
                        rowPosition = i;
                        colPosition = j;
                        sum = curentsum;
                    }
                }
            }
            Console.WriteLine($"{matrix[rowPosition][colPosition]} {matrix[rowPosition][colPosition + 1]}");
            Console.WriteLine($"{matrix[rowPosition + 1][colPosition]} {matrix[rowPosition + 1][colPosition + 1]}");
            Console.WriteLine(sum);
        }
    }
}
