namespace task07
{
    using System;
    using System.Numerics;

   public class Program
    {
       public static void Main()
        {
            var firstnumber = BigInteger.Parse(Console.ReadLine());
            var secondNumber = BigInteger.Parse(Console.ReadLine());

            var sum = firstnumber + secondNumber;

            Console.WriteLine(sum);
        }
    }
}
