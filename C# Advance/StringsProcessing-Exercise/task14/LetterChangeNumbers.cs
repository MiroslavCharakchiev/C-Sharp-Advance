using System;
using System.Collections.Generic;

namespace task14
{
    public class LetterChangeNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            var dict = CreateDict();

            var firstLetter = string.Empty;
            var secondLetter = string.Empty;
            var number = 0.0;
            var temp = 0.0;
            var sum = 0.0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length > 2)
                {

                    firstLetter = input[i].Substring(0, 1);
                    secondLetter = input[i].Substring(input[i].Length - 1);
                    number = double.Parse(input[i].Substring(1, input[i].Length - 2));
                    var isFirstLetterUpper = false;
                    var isSecondLetterUpper = false;
                    if (number != 0)
                    {


                        if (!dict.ContainsKey(firstLetter))
                        {
                            isFirstLetterUpper = true;
                            firstLetter = firstLetter.ToLower();
                        }
                        if (!dict.ContainsKey(secondLetter))
                        {
                            isSecondLetterUpper = true;
                            secondLetter = secondLetter.ToLower();
                        }

                        temp = CalcolateWithFirstLetter(dict, number, firstLetter, isFirstLetterUpper);
                        temp = CalcolateWithSecondLetter(dict, temp, secondLetter, isSecondLetterUpper);
                        sum += temp;
                    }

                }

            }
            Console.WriteLine($"{sum:f2}");



        }

        private static Dictionary<string, int> CreateDict()
        {
            var dict = new Dictionary<string, int>();
            dict["a"] = 1;
            dict["b"] = 2;
            dict["c"] = 3;
            dict["d"] = 4;
            dict["e"] = 5;
            dict["f"] = 6;
            dict["g"] = 7;
            dict["h"] = 8;
            dict["i"] = 9;
            dict["j"] = 10;
            dict["k"] = 11;
            dict["l"] = 12;
            dict["m"] = 13;
            dict["n"] = 14;
            dict["o"] = 15;
            dict["p"] = 16;
            dict["q"] = 17;
            dict["r"] = 18;
            dict["s"] = 19;
            dict["t"] = 20;
            dict["u"] = 21;
            dict["v"] = 22;
            dict["w"] = 23;
            dict["x"] = 24;
            dict["y"] = 25;
            dict["z"] = 26;
            return dict;
        }

        private static double CalcolateWithSecondLetter(Dictionary<string, int> dict, double sum, string secondLetter, bool isSecondLetterUpper)
        {
            var value = 0.0;

            if (isSecondLetterUpper)
            {
                value = sum - dict[secondLetter];
            }
            else
            {
                value = sum + dict[secondLetter];
            }
            return value;
        }

        private static double CalcolateWithFirstLetter(Dictionary<string, int> dict, double number, string firstLetter, bool isFirstLetterUpper)
        {
            var value = 0.0;
            if (isFirstLetterUpper)
            {
                value = (number / dict[firstLetter]);
            }
            else
            {
                value = number * dict[firstLetter];
            }
            return value;
        }
    }
}
