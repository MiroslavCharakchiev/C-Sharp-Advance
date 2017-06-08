
namespace task01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

   public class Studentsresults
    {
       public static void Main()
       {
           var input = int.Parse(Console.ReadLine());
           Console.WriteLine(string.Format("{0, -10}|{1,7}|{2,7}|{3,7}|{4,7}", "Name", "Cadv", "COOP", "AdvOOP", "Average"));
           for (int i = 0; i < input; i++)
           {
                var students = Console.ReadLine().Split(new char[]{' ', '-', ',' },StringSplitOptions.RemoveEmptyEntries);
               var student = students[0];
               var firstGrade = double.Parse(students[1]);
               var secondGrade = double.Parse(students[2]);
               var thirdGrade = double.Parse(students[3]);
               var average = (firstGrade + secondGrade + thirdGrade) / 3;

               Console.WriteLine(string.Format("{0, -10}|{1,7:f2}|{2,7:f2}|{3,7:f2}|{4,7:f4}", student, firstGrade, secondGrade, thirdGrade, average));

           }

       }
    }
}
