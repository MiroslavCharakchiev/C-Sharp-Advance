
namespace task02
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   public  class Program
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            var matrix = new int[number][];
            for (int i = 0; i < number; i++)
            {
                matrix[i] = new int[number];
                var input = Console.ReadLine().Split(new char []{' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.Length; j++)
                {
                    matrix[i][j] = input[j];
                }
            }
            var leftDiagonal = 0;
            var rightDiagonal = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                leftDiagonal += matrix[i][i];
                rightDiagonal += matrix[i][matrix.Length - i -1];
            }
            Console.WriteLine(Math.Abs(leftDiagonal - rightDiagonal));
        }
    }
}
