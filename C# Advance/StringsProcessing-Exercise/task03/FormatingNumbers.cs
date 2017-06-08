
namespace task03
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
   public class FormatingNumbers
    {
       public static void Main()
       {
           var input = Console.ReadLine().Split(new char[]{' ', '\t'},StringSplitOptions.RemoveEmptyEntries);
           var firstNumber = int.Parse(input[0]);
           var secondNumber = double.Parse(input[1]);
           var thirdNumber = double.Parse(input[2]);
           var binary = Convert.ToString(firstNumber, 2);
           if (binary.Length > 10)
           {
               binary = binary.Substring(0, 10);
           }

           Console.WriteLine(string.Format("|{0,-10}|{1,10}|{2,10:f2}|{3,-10:f3}|", firstNumber.ToString("X"), binary.PadLeft(10, '0'), secondNumber, thirdNumber));

       }
    }
}
