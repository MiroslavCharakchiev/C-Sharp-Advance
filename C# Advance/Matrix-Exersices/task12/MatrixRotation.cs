
namespace task12
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

   public  class MatrixRotation
    {
       public static void Main()
       {
           var rotation = Console.ReadLine()
               .Split("()".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
               .ToArray();

            var degrees = int.Parse(rotation[1]);
            var list = new List<string>();
           var length = 0;
           while (true)
           {
               var input = Console.ReadLine();
               if (input == "END")
               {
                   break;
               }
               list.Add(input);
               if (length < input.Length)
               {
                   length = input.Length;
               }
           }
           
           var matrix = new char[list.Count][];

           for (int i = 0; i < matrix.Length; i++)
           {
               var line = list[i].ToCharArray();

                matrix[i] = new char[length];
               for (int j = 0; j < matrix[i].Length; j++)
               {
                   if (j < line.Length)
                   {
                       matrix[i][j] = line[j];
                   }
                   else
                   {
                       matrix[i][j] = ' ';
                   }
               }
           }
            if (degrees % 360 == 180)
            {
                for (int i = matrix.Length - 1; i >= 0; i--)
                {
                    for (int j = matrix[i].Length - 1; j >= 0; j--)
                    {
                        Console.Write(matrix[i][j]);
                    }
                    Console.WriteLine();
                }
            }
            if (degrees % 360 == 0)
            {
                foreach (var row in matrix)
                {
                    Console.WriteLine(string.Join("", row));
                }
            }
           if (degrees % 360 == 90)
           {
               for (int i = 0; i < matrix[0].Length; i++)
               {
                   for (int j = matrix.Length-1; j >= 0; j--)
                   {
                       Console.Write(matrix[j][i]);
                   }
                   Console.WriteLine();
               }
           }
           if (degrees % 360 == 270)
           {
               for (int i = matrix[0].Length -1; i >= 0 ; i--)
               {
                   for (int j = 0; j < matrix.Length; j++)
                   {
                       Console.Write(matrix[j][i]);
                   }
                   Console.WriteLine();
               }
           }

        }
    }
}
