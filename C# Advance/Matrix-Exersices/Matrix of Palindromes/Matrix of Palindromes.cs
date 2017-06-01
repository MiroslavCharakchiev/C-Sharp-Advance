
namespace Matrix_of_Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class Program
    {
       public  static void Main()
       {
           var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

           var matrix = new string[input[0]][];


           for (int i = 0; i < matrix.Length; i++)
           {

               matrix[i] = new string[input[1]];
               for (int j = 0; j < matrix[i].Length; j++)
               {
                   matrix[i][j] = $"{alphabet[i]}{alphabet[i + j]}{alphabet[i]}";
               }
           }
           foreach (var row in matrix)
           {
               Console.WriteLine(string.Join(" ", row));
           }
       }
    }
}
