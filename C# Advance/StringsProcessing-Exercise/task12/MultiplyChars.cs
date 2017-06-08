
namespace task12
{
    using System;
    using System.Linq;

    public class MultiplyChars
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var first = input[0].ToArray();
            var second = input[1].ToArray();
            var sum = 0;


            if (first.Length == second.Length)
            {
                for (int i = 0; i < input[0].Length; i++)
                {
                    sum += first[i] * second[i];
                }
            }
            else
            {
                if (first.Length < second.Length)
                {
                    for (int i = 0; i < second.Length; i++)
                    {
                        if (i < first.Length)
                        {
                            sum += first[i] * second[i];
                        }
                        else
                        {
                            sum += second[i];
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < first.Length; i++)
                    {
                        if (i < second.Length)
                        {
                            sum += first[i] * second[i];
                        }
                        else
                        {
                            sum += first[i];
                        }
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
