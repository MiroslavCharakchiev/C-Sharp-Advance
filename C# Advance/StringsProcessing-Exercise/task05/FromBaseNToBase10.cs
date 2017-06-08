
namespace task05
{
    using System;
    using System.Linq;
    using System.Numerics;
   public  class FromBaseNToBase10
    {
       public static void Main()
        {
            var input = Console.ReadLine().Split();

            var firstNumber = BigInteger.Parse(input[0]);
            var secondNumber = input[1].ToArray();

            var result = secondNumber.Reverse().ToArray();
            BigInteger sum = 0;

            for (int i = 0; i < result.Length; i++)
            {
                var temp = (BigInteger)char.GetNumericValue(result[i]);
                var power = BigInteger.Pow(firstNumber, i);
                sum += (temp * power);
            }

            Console.WriteLine(sum);
        }
    }
}
