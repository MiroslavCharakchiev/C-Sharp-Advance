
namespace _08
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Problem8
    {
        private static long[] fibNumbers;
        public static void Main(string[] args)
        {
            var number = long.Parse(Console.ReadLine());
            fibNumbers = new long[number];
            var result = GetFibNumber(number);
            Console.WriteLine(result);


        }

        private static long GetFibNumber(long number)
        {
            if (number <= 2)
            {
                return 1;
            }
            if (fibNumbers[number -1] != 0)
            {
               return fibNumbers[number - 1];
            }
            return fibNumbers[number - 1] = GetFibNumber(number - 1) + GetFibNumber(number - 2);
        }
    }
}
