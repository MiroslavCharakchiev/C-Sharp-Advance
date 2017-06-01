
namespace task03
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   public  class Program
    {
       public  static void Main()
       {
           var frame = Console.ReadLine()
               .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

           var matrix = new String [frame[0]][];

           for (int i = 0; i < matrix.Length; i++)
           {
               matrix[i] = new String [frame[1]];
               var input = Console.ReadLine().Split();
               for (int j = 0; j < matrix[i].Length; j++)
               {
                   matrix[i][j] = input[j];
               }

           }
           var count = 0;
           for (int i = 0; i < matrix.Length-1; i++)
           {
               for (int j = 0; j < matrix[i].Length -1; j++)
               {
                   if (matrix[i][j] == matrix[i][j + 1]
                       && matrix[i][j] == matrix[i + 1][j]
                       && matrix[i][j] == matrix[i + 1][j + 1])
                   {
                       count++;
                   }
                }
              
           }
         
           Console.WriteLine(count);
           
       }
    }
}
